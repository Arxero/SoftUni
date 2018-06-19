const handlers = require('../handlers/handlerBlender')
const multer = require('multer')
var path = require('path')
const crypto = require('crypto') 

let storage = multer.diskStorage({
    destination: './public/memeStorage/multer',
    filename: function (req, file, cb) {
      crypto.pseudoRandomBytes(16, function (err, raw) {
        if (err) return cb(err)
  
        cb(null, raw.toString('hex') + path.extname(file.originalname))
      })
    }
  })

  let upload = multer({ storage: storage });

module.exports = (app) => {
    app.get('/', handlers.home.index)

    app.get('/addMeme', handlers.meme.addMemeGet)
    app.post('/addMeme', upload.single('meme'), handlers.meme.addMemePost)

    app.get('/viewAllMemes', handlers.meme.viewAllGet)
    app.get('/getDetails', handlers.meme.getDetailsGet)

    app.get('/searchMeme', handlers.meme.searchMemeGet)
    app.post('/searchMeme', handlers.meme.searchMemePost)

    app.get('/addGenre', handlers.meme.addGenreGet)
    app.post('/addGenre', handlers.meme.addGenrePost)

    app.get('/status', handlers.meme.statusGet)


}