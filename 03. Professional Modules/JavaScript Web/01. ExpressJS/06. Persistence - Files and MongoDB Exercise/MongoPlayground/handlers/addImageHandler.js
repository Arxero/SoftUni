const Image = require('mongoose').model('Image')
const formidable = require('formidable')
const ObjectId = require('mongoose').Types.ObjectId

function addImage(req, res) {
    let form = new formidable.IncomingForm()
    form.parse(req, (err, fields, files) => {
        if (err) {
            console.log(err)
        }

        const tags = fields.tagsID.split(',').reduce((a, b) => {
            if (a.includes(b) || b == '') {
                return a
            } else {
                a.push(b)
                return a
            }
        }, []).map(ObjectId)

        Image.create({
            url: fields.imageUrl,
            title: fields.imageTitle,
            description: fields.description,
            tags
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
                'content-type': 'text/plain'
            })
            res.write('500 Server Error')
            res.end()
        })

    })
}

function deleteImg(req, res) {
    Image.deleteOne({_id: req.pathquery.id}).then(() => {
        res.writeHead(302, {
            Location: '/'
        })
        res.end()
    }).catch(err => {
        if (err) {
            console.log(err)
        }
        res.writeHead(500, {
            'content-type': 'text/plain'
        })
        res.write('500 Server Error')
        res.end()
    })

  
}


module.exports = (req, res) => {
    if (req.pathname === '/addImage' && req.method === 'POST') {
        addImage(req, res)
    } else if (req.pathname === '/delete' && req.method === 'GET') {
        deleteImg(req, res)
    } else {
        return true
    }
}
