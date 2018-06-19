const url = require('url')
const fs = require('fs')
const path = require('path')
const database = require('../config/dataBase')
const qs = require('querystring')
const shortid = require('shortid')
const formidable = require('formidable')
const compression = require('compression')


function viewAll(req, res) {
    // let folderToUpload = '0'
    // let imagesCount = 0
    // let filePathReadDir = path.normalize(path.join(__dirname, '../public/test/'))
    // fs.readdir(filePathReadDir, (err, folders) => {
    //     if (err) {
    //         console.log(err)
    //     }
    //     for (let folder of folders) {
    //         fs.readdir(filePathReadDir + folder, (err, files) => {

    //             imagesCount += files.length
    //             if (imagesCount >= files.length) {
    //                 //console.log('yes')
    //                 console.log(imagesCount)
    //                 if (imagesCount > (folders.length * 2)) {
    //                     fs.mkdir(filePathReadDir + folders.length, () => {
    //                               console.log('Directory Created')
    //                            })
    //                 }
    //             }
    //             // if (files.length > 1) {
    //             //    fs.mkdir(filePathReadDir + (folders.length + 1), () => {
    //             //       console.log('Directory Created')
    //             //    })
    //             // }
                    
    //             //console.log(imagesCount)
    //         })
    //     }
    //     //console.log(12 % 500)

    // })


    let filePath = path.normalize(path.join(__dirname, '../views/viewAll.html'))

    fs.readFile(filePath, (err, data) => {
        if (err) {
            console.log(err)
            res.writeHead(404, {
                'content-type': 'text/plain'
            })
            res.write('404 Not Found')
            res.end()
            return
        }

        database.load().then((memes) => {
            let content = ''
            for (let meme of memes.sort(x => x.dateStamp).reverse()) {
                if (meme.privacy == 'on') {
                    content += `
             <div class="meme">
               <a href="/getDetails?id=${meme.id}">
               <img class="memePoster" src="${meme.memeSrc}"/>
             </div>`
                }

            }
            let html = data.toString().replace('<div id="replaceMe">{{replaceMe}}</div>', content)

            compression(res.writeHead(200, {
                'content-type': 'text/html'
            }))
            compression(res.write(html))
            res.end()
        })

    })
}


function getDetails(req, res) {
    let filePath = path.normalize(path.join(__dirname, '../views/details.html'))

    fs.readFile(filePath, (err, data) => {
        if (err) {
            console.log(err)
            res.writeHead(404, {
                'content-type': 'text/plain'
            })
            res.write('404 Not Found')
            res.end()
            return
        }
        database.load().then((memes) => {
            let id = qs.parse(req.url)['/getDetails?id']
            let targetedMeme = memes.filter(x => x.id == id)[0]

            let content = `<div class="content">
        <img src="${targetedMeme.memeSrc}" alt=""/>
        <h3>Title ${targetedMeme.title}</h3>
        <p> ${targetedMeme.description}</p>
        <button><a href="${targetedMeme.memeSrc}" download>Download Meme</a></button>
      </div>`

            let html = data.toString().replace('<div id="replaceMe">{{replaceMe}}</div>', content)

            compression(res.writeHead(200, {
                'content-type': 'text/html'
            }))
            compression(res.write(html))
            res.end()
        })
    })
}


function viewAddMeme(req, res) {
    let filePath = path.normalize(path.join(__dirname, '../views/addMeme.html'))

    fs.readFile(filePath, (err, data) => {
        if (err) {
            console.log(err)
            res.writeHead(404, {
                'content-type': 'text/plain'
            })
            res.write('404 Not Found')
            res.end()
            return
        }
        compression(res.writeHead(200, {
            'content-type': 'text/html'
        }))
        compression(res.write(data))
        res.end()
    })
}

function addMeme(req, res) {
    let form = new formidable.IncomingForm()

    let uploadDirectory = path.normalize(path.join(__dirname, '../public/memeStorage/uploaded/'))
    let fileName = shortid.generate()
    form.uploadDir = uploadDirectory
    //form.file.name = fileName

    form.parse(req, (err, fields, file) => {
        if (err) {
            console.log(err)
            res.writeHead(404, {
                'content-type': 'text/plain'
            })
            res.write('404 Not Found')
            res.end()
            return
        }
        let exstension = file.meme.name.split('.').pop()
        fs.rename(file.meme.path, form.uploadDir + fileName + '.' + exstension, err => {
            if (err) {
                console.log(err)
            }
            let meme = {
                'dateStamp': Date.now(),
                'description': fields.memeDescription,
                'id': fileName,
                'memeSrc': './public/memeStorage/uploaded/' + fileName + '.' + exstension,
                'title': fields.memeTitle,
                'privacy': fields.status
            }
            database.add(meme)
            database.save().then(() => {
                compression(res.writeHead(302, {
                    Location: '/viewAllMemes'
                }))
                res.end()

            })

        })
    })
}



module.exports = (req, res) => {
    if (req.pathname === '/viewAllMemes' && req.method === 'GET') {
        viewAll(req, res)
    } else if (req.pathname === '/addMeme' && req.method === 'GET') {
        viewAddMeme(req, res)
    } else if (req.pathname === '/addMeme' && req.method === 'POST') {
        addMeme(req, res)
    } else if (req.pathname.startsWith('/getDetails') && req.method === 'GET') {
        getDetails(req, res)
    } else {
        return true
    }
}
