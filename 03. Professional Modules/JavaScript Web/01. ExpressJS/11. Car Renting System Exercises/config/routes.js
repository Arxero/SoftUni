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

    app.get('/users/register', controllers.user.registerGet)
    app.post('/users/register', controllers.user.registerPost)

    app.get('/users/login', controllers.user.loginGet)
    app.post('/users/login', controllers.user.loginPost)

    app.get('/users/logout', controllers.user.logout)

    app.get('/cars/all', controllers.cars.viewAll)

    app.get('/cars/create', auth.isInRole('Admin'), controllers.cars.addCarGet)
    app.post('/cars/create', auth.isInRole('Admin'), upload.single('imageUrl'), controllers.cars.addCarPost)

    app.get('/users/profile/me', auth.isAuthenticated, controllers.user.profile)


    app.get('/cars/edit/:id', auth.isAuthenticated, auth.isInRoleAndWeEdit('Admin'), controllers.cars.editCarGet)
    app.post('/cars/edit/:id', auth.isInRole('Admin'), upload.single('imageUrl'), controllers.cars.editCarPost)


    app.get('/cars/rent/:id', auth.isAuthenticated, controllers.cars.rentCarGet)
    app.post('/cars/rent/:id', auth.isAuthenticated, controllers.cars.rentCarPost)
}