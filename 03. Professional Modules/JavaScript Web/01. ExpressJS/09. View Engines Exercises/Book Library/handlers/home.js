const Book = require('../models/Book')


module.exports.index = (req, res) => {
    Book.count().then((count) => {
        res.render('index', {content: count})
    })
}