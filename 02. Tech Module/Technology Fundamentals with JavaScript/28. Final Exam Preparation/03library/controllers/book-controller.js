const Book = require('../models/Book');

function getAll() {
    return Book.find({})
}

function addTask(book) {
    return Book.create(book)
}

function findById(id) {
    return Book.findById(id)
}

function editBook(id, newBook) {
    return Book.findOneAndUpdate(id, newBook)
}

function deleteBook(id) {
    return Book.findOneAndDelete(id)
}


module.exports = {
    getIndex: function (req, res) {
        getAll().then(books => {
            return res.render('index', { books })
        })
    },
    getCreate: function (req, res) {
        return res.render('create')
    },
    postCreate: function (req, res) {
        addTask(req.body).then(() => {
            return res.redirect('/')
        })
    },
    getEdit: function (req, res) {
        findById(req.params.id).then(book => {
            return res.render('edit', { book })
        })
    },
    postEdit: function (req, res) {
        editBook(req.params.id, req.body).then(() => {
            return res.redirect('/')
        })
    },
    getDelete: function (req, res) {
        findById(req.params.id).then(book => {
            return res.render('delete', { book })
        })
    },
    postDelete: function (req, res) {
        deleteBook(req.params.id).then(() => {
            return res.redirect('/')
        })
    }
};