const controllers = require('../controllers')
const multer = require('multer')
const path = require('path')
const crypto = require('crypto')
const shortid = require('shortid')
const auth = require('./auth')


let storage = multer.diskStorage({
    destination: './content/images/uploaded',
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

    app.get('/product/add', auth.isAuthenticated, controllers.product.addGet)
    app.post('/product/add', auth.isAuthenticated, upload.single('image'), controllers.product.addPost)

    app.get('/category/add', auth.isInRole('Admin'), controllers.category.addGet)
    app.post('/category/add', auth.isInRole('Admin'),  controllers.category.addPost)
    
    app.get('/category/:category/products', controllers.category.productByCategory)

    app.get('/product/edit/:id', auth.isAuthenticated, controllers.product.editGet)
    app.post('/product/edit/:id', auth.isAuthenticated, upload.single('image'), controllers.product.editPost)

    app.get('/product/delete/:id', auth.isAuthenticated, controllers.product.deleteGet)
    app.post('/product/delete/:id', auth.isAuthenticated, controllers.product.deletePost)

    app.get('/product/buy/:id', auth.isAuthenticated, controllers.product.buyGet)
    app.post('/product/buy/:id', auth.isAuthenticated, controllers.product.buyPost)

    app.get('/user/register', controllers.user.registerGet)
    app.post('/user/register', controllers.user.registerPost)

    app.get('/user/login', controllers.user.loginGet)
    app.post('/user/login', controllers.user.loginPost)

    app.post('/user/logout', auth.isAuthenticated, controllers.user.logout)

    
}