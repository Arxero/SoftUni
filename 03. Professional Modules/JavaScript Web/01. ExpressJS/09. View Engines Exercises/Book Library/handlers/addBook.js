const Book = require('../models/Book')


module.exports.addBookGet = (req, res) => {
    res.render('addBook')
}

module.exports.addBookPost = (req, res) => {
    let image = req.body.bookPoster

    if (req.file != undefined) {
        image = '\\' + req.file.path
    }

    let book = {
        title: req.body.bookTitle,
        year: req.body.bookYear,
        image,
        author: req.body.bookAuthor,
    }
    
    Book.create(book).then(() => {
        res.render('addBook', {message: `<div id="succssesBox"><h2 id="succssesMsg">Book Added</h2></div>`})
        //setTimeout(() => {res.redirect('/viewAllBooks')}, 2000)
        //res.redirect('/viewAllBooks')
    }).catch(() => {
        res.render('addBook', {message: `<div id="errBox"><h2 id="errMsg">Please fill all fields</h2></div>`})
    })
}