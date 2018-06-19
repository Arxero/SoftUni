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

    app.get('/product/create', auth.isInRole('Admin'), controllers.product.createGet)
    app.post('/product/create', auth.isInRole('Admin'), controllers.product.createPost)
    
    app.get('/order/status', auth.isAuthenticated, controllers.product.statusGet)
    app.post('/order/status', auth.isInRole('Admin'), controllers.product.statusPost)
    
    app.get('/order/:id', auth.isAuthenticated, controllers.product.orderGet)
    app.post('/order/:id', auth.isAuthenticated, controllers.product.orderPost)

    app.get('/order/details/:id', auth.isAuthenticated, controllers.product.detailsGet)

    app.get('/delete/:id', auth.isInRole('Admin'), controllers.product.deleteGet)
    app.post('/delete/:id', auth.isInRole('Admin'), controllers.product.deletePost)
    
    app.get('/edit/:id', auth.isInRole('Admin'), controllers.product.editGet)
    app.post('/edit/:id', auth.isInRole('Admin'), controllers.product.editPost)
}