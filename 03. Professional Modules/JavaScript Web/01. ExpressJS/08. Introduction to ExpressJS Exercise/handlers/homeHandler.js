const fs = require('fs')


module.exports.index = (req, res) => {
    fs.readFile('./views/home.html', (err, data) => {
        if (err) {
            console.log(err)
            return
        }
        res.writeHead(200, {
            'Content-Type': 'text/html'
        })
        res.end(data)
    })
}
