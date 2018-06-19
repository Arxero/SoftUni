const fs = require('fs')
const path = require('path')
const db = require('../config/dataBase')

module.exports = (req, res) => {
    req.pathname = req.pathname || url.parse(req.url).pathname
    
    if (req.headers.statusheader == 'Full' || req.pathname == '/status') {
        let filePath = path.normalize(path.join(__dirname, '../views/status.html'))
        
        fs.readFile(filePath, (err, data) => {
            if (err) {
                console.log(err)
                res.writeHead(404, {
                    'content-type' : 'text/plain'
                })
                res.write('404 Not Found')
                res.end()
                return
            }
            res.writeHead(200, {
                'content-type' : 'text/html'
            })
            let html = data.toString().replace('{{replaceMe}}', `There are currently ${db.length} movies.`)
            res.write(html)
            res.end()
        })
    }else {
        return true
    }
}