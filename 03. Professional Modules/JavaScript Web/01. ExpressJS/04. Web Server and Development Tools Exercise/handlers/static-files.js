const url = require('url')
const fs = require('fs')
const path = require('path')

function getContentType(url) {
    if (url.endsWith('.css')) {
        return 'text/css'
    } else if (url.endsWith('.ico')) {
        return 'image/x-icon'
    } else if (url.endsWith('.png')) {
        return 'image/png'
    } else if (url.endsWith('.jpg')) {
        return 'image/png'
    } else if (url.endsWith('.jpeg')) {
        return 'image/png'
    } else if (url.endsWith('.gif')) {
        return 'image/png'
    } else if (url.endsWith('.html')) {
        return 'text/html'
    } else if (url.endsWith('.js')) {
        return 'text/javascript'
    }

}

module.exports = (req, res) => {
    req.pathname = req.pathname || url.parse(req.url).pathname
    let allowedFiles = [
        'html',
        'css',
        'js',
        'png',
        'jpg',
        'ico',
    ]
    let exstension = req.pathname.split('.').pop()

    if (req.pathname.startsWith('/public/') && req.method == 'GET' && allowedFiles.includes(exstension)) {
        let filePath = path.normalize(path.join(__dirname, `..${req.pathname}`))

        fs.readFile(filePath, (err, data) => {
            if (err) {
                console.log(err);
                res.writeHead(404, {
                    'content-type': 'text/plain'
                })
                res.write('Resource not found!')
                res.end()
                return
            }
            res.writeHead(200, {
                'content-type': getContentType(req.pathname)
            })
            res.write(data)
            res.end()
        })
    } else {
        return true
    }
}