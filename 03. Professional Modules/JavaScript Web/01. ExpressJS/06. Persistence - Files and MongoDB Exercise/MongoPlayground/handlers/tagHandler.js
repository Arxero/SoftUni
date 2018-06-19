const formidable = require('formidable')
const Tag = require('mongoose').model('Tag')


module.exports = (req, res) => {
    if (req.pathname === '/generateTag' && req.method === 'POST') {
        let form = new formidable.IncomingForm()
        form.parse(req, (err, fields, files) => {
            res.writeHead(200, {
                'content-type': 'text/plain'
            });
            const name = fields.name
            Tag.create({
                name,
                images: [fields.tags]
            }).then(() => {
                res.writeHead(302, {
                    Location: '/'
                })
                res.end()
            }).catch(err => {
                if (err) {
                    console.log(err)
                }
                res.writeHead(500, {
                    'content-type' : 'text/plain'
                })
                res.write('500 Server Error')
                res.end()
            })
        })
    } else {
        return true
    }
}
