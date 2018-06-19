const handlers = require('../handlers/index')
const multer = require('multer')
const path = require('path')
const crypto = require('crypto') 
const shortid = require('shortid')

let storage = multer.diskStorage({
    destination: './public/uploaded',
    filename: function (req, file, cb) {
      crypto.pseudoRandomBytes(16, function (err, raw) {
        if (err) return cb(err)
  
        cb(null, shortid.generate() + path.extname(file.originalname))
      })
    }
  })

  let upload = multer({ storage: storage });

module.exports = (app) => {
     app.get('/', handlers.home.index)

     app.get('/viewAllBooks', handlers.viewAll.viewAll)

     app.get('/addBook', handlers.addBook.addBookGet)
     app.post('/addBook', upload.single('bookPoster'), handlers.addBook.addBookPost)

     app.get('/details', handlers.details.details)
}