const Book = require('../models/Book')


module.exports.details = (req, res) => {
    let id = req.originalUrl.split('=').pop()
    
    Book.findById(id).then((book) => {
        let content = `<img src="${book.image}" alt=""/>
        <h3>${book.title}</h3>
        <h3>By ${book.author}</h3>
        <p>Released ${book.year}</p>`

        res.render('details', { content })
    })
}