const Book = require('../models/Book')
const seeds = require('../database/booksdb')


module.exports.viewAll = (req, res) => {
    Book.find().sort('-dateAdded').then((books) => {
        if (books.length == 0) {
            Book.create(seeds).then((createdBoooks) => {
                renderBooks(createdBoooks)
            })
        } else {
            renderBooks(books)
        }
    })

    function renderBooks(books) {
        let content = ''
        for (let book of books) {
            content += `<div class="book">
                        <a href="/details?id=${book._id}"><img class="bookPoster" src="${book.image}" /></a>
                        </div>`

        }
        res.render('viewAll', { content })
    }
}