const User = require('../models/User')
const encryption = require('../utilities/encryption')

module.exports.registerGet = (req, res) => {
    res.render('user/register')
}

module.exports.registerPost = (req, res) => {
    let user = req.body
    let salt = encryption.generateSalt()
    user.salt = salt

    if (user.password != user.repeatedPassword) {
        user.error = 'Passwords do not match.'
        res.render('user/register', user)
        return
    }

    if (user.password) {
        let hashedPassword = encryption.generateHashedPassword(salt, user.password)
        user.password = hashedPassword
    }

    User.create(user).then((user) => {
        req.logIn(user, (error, user) => {
            if (error) {
                res.render('user/register', { error: 'Authentication not working!' })
                return
            }
            res.redirect('/?success=' + encodeURIComponent('Register Successful!'))

        })
    }).catch(error => {
        // If User.create fails this method will be invoked.
        user.error = error
        console.log(user.error)
        res.render('user/register', user)
    })
}

module.exports.loginGet = (req, res) => {
    res.render('user/login')
}

module.exports.loginPost = (req, res) => {
    let userToLogin = req.body

    User.findOne({ username: userToLogin.username }).then((user) => {
        if (!user || !user.authenticate(userToLogin.password)) {
            res.render('user/login', { error: 'Invalid credentials!' })
        } else {
            req.logIn(user, (error, user) => {
                if (error) {
                    res.render('user/login', { error: 'Authentication not working!' })
                    return
                }

                res.redirect('/?success=' + encodeURIComponent('Login Successful!'))
            })
        }
    })
}

module.exports.logout = (req, res) => {
    req.logout()
    res.redirect('/?success=' + encodeURIComponent('Logout Successful!'))
}