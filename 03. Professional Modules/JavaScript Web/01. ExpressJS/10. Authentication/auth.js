const router = require('express').Router()


const users = [
    {
        username: 'pesho',
        password: '123'
    }
]


router.get('/login', (req, res) => {
    const message = req.session.message
    req.session.message = ''
    res.render('login', { message, inputData: req.session.inputData })
})

router.post('/login', (req, res) => {
    const { username, password } = req.body
    const user = users.filter(x => x.username == username)[0]
    if (user != undefined) {
        if (user.password == password) {
            req.session.user = {
                username
            }
            req.session.message = 'Login successful'
            delete req.session.inputData
            return res.redirect('/')
        }
    }
    req.session.message = 'Incorrect credentials'
    req.session.inputData = {
        username,
        password
    }
    res.redirect('/auth/login')
})

router.get('/register', (req, res) => {
    const message = req.session.message
    req.session.message = ''
    res.render('register', { message, inputData: req.session.inputData })
})

router.post('/register', (req, res) => {
    const { username, password, repeat } = req.body
    if (password !== repeat) {
        return error('Password do not match')
    }
    if (users.filter(x => x.username == username).length > 0) {
        return error('Username is taken')
    }
    
    const user = {
        username,
        password
    }
    users.push(user)
    req.session.user = {
        username,
    }

    req.session.message = 'Registration Successful'
    return res.redirect('/')

    function error(message) {
        req.session.inputData = {
            username,
            password,
            repeat
        }
        req.session.message = message
        return res.redirect('/auth/register')
    }
})

module.exports = router