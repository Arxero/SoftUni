const controllers = require('../controllers')
const multer = require('multer')
const path = require('path')
const crypto = require('crypto')
const shortid = require('shortid')
const auth = require('./auth')


let storage = multer.diskStorage({
    destination: './public/images/uploaded',
    filename: function (req, file, cb) {
      crypto.pseudoRandomBytes(16, function (err, raw) {
        if (err) return cb(err)
  
        cb(null, shortid.generate() + path.extname(file.originalname))
      })
    }
  })

  let upload = multer({ storage: storage });

module.exports = (app) => {
    app.get('/', controllers.home.index)

    app.get('/user/register', controllers.user.registerGet)
    app.post('/user/register', controllers.user.registerPost)

    app.get('/user/login', controllers.user.loginGet)
    app.post('/user/login', controllers.user.loginPost)

    app.get('/user/logout', auth.isAuthenticated, controllers.user.logout)

    app.get('/article/create', auth.isAuthenticated, controllers.article.createGet)
    app.post('/article/create', auth.isAuthenticated, upload.single('image'), controllers.article.createPost)

    app.get('/user/profile', auth.isAuthenticated, controllers.user.profile)

    app.get('/article/details/:id', auth.isAuthenticated, controllers.article.details)

    app.get('/article/delete/:id', auth.isInRole('Admin'), controllers.article.deleteGet)
    app.post('/article/delete/:id', auth.isInRole('Admin'), controllers.article.deletePost)
    
    app.get('/article/edit/:id', auth.isInRole('Admin'), controllers.article.editGet)
    app.post('/article/edit/:id', auth.isInRole('Admin'), upload.single('image'), controllers.article.editPost)
    
}