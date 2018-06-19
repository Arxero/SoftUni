const http = require('http')
const fs = require('fs')
const formidable = require('formidable')

http.createServer((req, res) => {
    if (req.method == 'GET') {
        fs.readFile('./index.html', 'utf8', (err, data) => {
            if (err) {
                console.log(err)
                return
            }
            res.writeHead(200, {
                'content-type': 'text/html'
            })
            res.write(data)
            res.end()
        })

    } else if (req.method == 'POST') {
        let form = new formidable.IncomingForm()
        form.parse(req, (err, fields, files) => {
            if (err) {
                console.log(err)
            }

            let file = files.upload
            let temPath = file.path
            let fileName = file.name
            fs.rename(temPath, './files/' + fileName, err => {
                if (err) {
                    console.log(err)
                    return
                }
                res.write('Thank You!')
                res.end()
            })
        })

    }

}).listen(5000)
console.log('Linstening on port 5000...')