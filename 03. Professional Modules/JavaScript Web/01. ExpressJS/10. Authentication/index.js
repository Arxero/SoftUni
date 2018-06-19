const app = require('express')()
const cookieParser = require('cookie-parser')
const session = require('express-session')
const handlebars = require('express-handlebars')
const bodyParser = require('body-parser')
const authRouter = require('./auth')
const port = 5000


const products = [
    {
        name: 'Apple',
        price: 1
    },
    {
        name: 'Banana',
        price: 2
    },
    {
        name: 'Orange',
        price: 3
    },
]

app.engine('.hbs', handlebars({
    extname: '.hbs'
}))
app.set('view engine', '.hbs')

app.use(cookieParser())
app.use(session({
    secret: 'keyboard cat'
}))

app.use(bodyParser.urlencoded({ extended: true }))
app.use('/auth', authRouter)
app.use((req, res, next) => {
    if (req.session.user == undefined) {
       return res.redirect('/auth/login')
    }
    next()
})




app.get('/', (req, res) => {
    
    const username = req.session.user.username
    const numItems = req.session.cart ? req.session.cart.length : 0
    const message = req.session.message
    req.session.message = ''
    res.render('index', { products, numItems, message, username })
})

app.get('/add/:id', (req, res) => {
    if (req.session.cart === undefined) {
        req.session.cart = []
    }

    let product = products[Number(req.params.id)]
    req.session.cart.push(product)
    req.session.message = 'Product added to cart.'
    res.redirect('/')
})

app.get('/readSession', (req, res) => {
    res.json(req.session)
})

app.get('/cart', (req, res) => {
    let items = req.session.cart || []
    let numItems = items.length
    let total = items.reduce((a, b) => a + b.price, 0)
    res.render('cart', { items, numItems, total })
})

app.get('/remove/:id', (req, res) => {
    let items = req.session.cart || []
    let id = Number(req.params.id)
    req.session.cart = items.filter((p, i) => i != id)
    res.redirect('/cart')
})

app.listen(port)
console.log(`Listening on port ${port}...`)