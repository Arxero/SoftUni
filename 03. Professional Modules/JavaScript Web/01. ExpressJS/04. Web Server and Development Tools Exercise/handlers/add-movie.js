const url = require('url')
const fs = require('fs')
const path = require('path')
const qs = require('querystring')
const db = require('../config/dataBase')
let addMovie = ''

module.exports = (req, res) => {
    req.pathname = req.pathname || url.parse(req.url).pathname

    if (req.pathname == '/addMovie' && req.method == 'GET') {
        let filePath = path.normalize(path.join(__dirname, '../views/addMovie.html'))

        fs.readFile(filePath, (err, data) => {
            addMovie = data
            if (err) {
                console.log(err)
                res.writeHead(404, {
                    'content-type': 'text/plain'
                })
                res.write('Not Found')
                res.end()
                return
            }
            res.writeHead(200, {
                'content-type': 'text/html'
            })
            res.write(data)
            res.end()
        })
    } else if (req.pathname == '/addMovie' && req.method == 'POST') {

        let dataString = ''
        req.on('data', (data) => {
            dataString += data
        })

        req.on('end', () => {

            let movieData = qs.parse(dataString)
            let movieDataEncoded = {
                'movieTitle': encodeURI(movieData.movieTitle),
                'movieYear': encodeURI(movieData.movieYear),
                'moviePoster': encodeURI(movieData.moviePoster),
                'movieDescription': encodeURI(movieData.movieDescription),
            }

            if (movieData.movieTitle != '' && movieData.movieTitle != '' && movieData.moviePoster != '' && movieData.movieDescription != '') {
                db.push(movieDataEncoded)


                res.writeHead(200, {
                    'content-type': 'text/html'
                })
                let html = addMovie.toString().replace('<div id="replaceMe">{{replaceMe}}</div>', '<div id="succssesBox"><h2 id="succssesMsg">Movie Added</h2></div>')
                res.write(html)
                res.end()
                
            } else {
                res.writeHead(200, {
                    'content-type': 'text/html'
                })
                let html = addMovie.toString().replace('<div id="replaceMe">{{replaceMe}}</div>', '<div id="errBox"><h2 id="errMsg">Please fill all fields</h2></div>')
                res.write(html)
                res.end()
                return
            }

            // let filePathDatabse = path.normalize(path.join(__dirname, '../config/dataBase.js'))
            // fs.writeFile(filePathDatabse, db, { encoding: 'utf8' } , (err) => {
            //     if (err) {
            //         console.log(err)
            //         return
            //     }
            //     console.log("The file was saved!");
            // })


        })


    } else {
        return true
    }
}