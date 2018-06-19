const Image = require('mongoose').model('Image')
const fs = require('fs')
const Tag = require('mongoose').model('Tag')

module.exports = (req, res) => {
    if (req.pathname === '/search') {
        fs.readFile('./views/results.html', (err, data) => {
            if (err) {
                console.log(err)
                return
            }

            let params = {}

            if (req.pathquery.tagName) {
                let tags = req.pathquery.tagName.split(',').filter(x => x.length > 0).map(x => x.trim())
                if (tags.length > 0) {
                    Tag.find({ name: { $in: tags } }).then(data => {
                        let tagIds = data.map(x => x._id)
                        params.tags = tagIds
                        getImagesAndRespond(params)
                    })
                }
            } else {
                getImagesAndRespond(params)
            }

            function getImagesAndRespond(params) {
                let limit = 0

                if (req.pathquery.Limit) {
                    limit = Number(req.pathquery.Limit)
                }
                if (req.pathquery.afterDate) {
                    let afterDate = new Date(req.pathquery.afterDate)
                    params.creationDate = { $gte: afterDate}
                }
                if (req.pathquery.beforeDate) {
                    let beforeDate = new Date(req.pathquery.beforeDate)
                    params.creationDate = { $lte: beforeDate}
                }

                Image.find(params).limit(limit).then((images) => {
                    let dataString = ''

                    for (let image of images.reverse()) {
                        dataString += `<fieldset id="${image._id}" <legend>${image.title}:</legend>
                                            <img src="${image.url}"></img>
                                            <p>${image.description}<p/>
                                            <button onclick='location.href="/delete?id=${image._id}"'class='deleteBtn'>Delete</button>
                                        </fieldset>`
                    }
                    let html = data.toString().replace(`<div class='replaceMe'></div>`, dataString)

                    res.writeHead(200, {
                        'content-type': 'text/html'
                    })
                    res.write(html)
                    res.end()
                })
            }
        })

    } else {
        return true
    }
}
