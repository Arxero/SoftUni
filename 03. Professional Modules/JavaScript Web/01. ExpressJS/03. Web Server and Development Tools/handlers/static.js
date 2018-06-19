const fs = require('fs')
const mimeTypes = {
    'css': 'text/css',
    'js': 'application/javascript',
    'png': 'image/png'
}

function staticHandler(req, res) {
    if (req.path.startsWith('/static/')) {
        const exstension = req.path.split('.').pop()
        res.writeHead(200, {
            'content-type': mimeTypes[exstension]
        })

        try {
            const read = fs.createReadStream('.' + req.path)
            read.pipe(res)
        } catch (error) {
            console.log(error)
            return true
        }
    } else {
        return true
    }
}

module.exports = staticHandler