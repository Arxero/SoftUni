const User = require('../models/User')
const Car = require('../models/Car')
const encryption = require('../utilities/encryption')

module.exports.registerGet = (req, res) => {
    res.render('users/register')
}

module.exports.registerPost = (req, res) => {
    let user = req.body
    let salt = encryption.generateSalt()
    user.salt = salt

    if (user.password) {
        let hashedPassword = encryption.generateHashedPassword(salt, user.password)
        user.password = hashedPassword
    }

    User.create(user).then((user) => {
        req.logIn(user, (error, user) => {
            if (error) {
                res.render('users/register', { error: 'Authentication not working!' })
                return
            }
            res.redirect('/?success=' + encodeURIComponent('Registration successful!'))

        })
    }).catch(error => {
        // If User.create fails this method will be invoked.
        user.error = error
        console.log(user.error)
        res.render('users/register', { error })
    })
}

module.exports.loginGet = (req, res) => {
    res.render('users/login')
}

module.exports.loginPost = (req, res) => {
    let user = req.body

    User.findOne({ username: user.username }).then((userFound) => {
        if (!userFound || !userFound.authenticate(user.password)) {
            //user.error = 'Invalid credentials!'
            res.render('users/login', { error: 'Invalid credentials!'})
        } else {
            req.logIn(userFound, (error, user) => {
                if (error) {
                    res.render('users/login', { error: 'Authentication not working!' })
                    return
                }

                res.redirect('/?success=' + encodeURIComponent('Login successful!'))
            })
        }
    })
}

module.exports.logout = (req, res) => {
    req.logout()
    res.redirect('/?success=' + encodeURIComponent('Logout successful!'))
}

module.exports.profile = (req, res) => {
    let userId = req.session.passport.user

    User.findById(userId).then(user => {
        res.render('users/profile', {username: user.username, rentedCars: user.rentedCars})
    })
}