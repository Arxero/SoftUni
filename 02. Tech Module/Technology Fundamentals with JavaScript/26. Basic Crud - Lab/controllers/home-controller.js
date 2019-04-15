const Product = require('../models/Product')

function getAll() {
    return Product.find({})
}

function addProduct(product) {
    return Product.create(product)
}

function findById(id) {
    return Product.findById(id)
}

function editProduct(id, newProduct) {
    return Product.findOneAndUpdate(id, newProduct)
}

function deleteProduct(id) {
    return Product.findOneAndDelete(id)
}

module.exports = {
    getIndex: function (req, res) {
        getAll().then(products => {
            res.render('index', { products })
        })
    },
    getCreate: function (req, res) {
        return res.render('create')
    },
    postCreate: function (req, res) {
        addProduct(req.body).then(() => {
            return res.redirect('/')
        })
    },
    getEdit: function (req, res) {
        findById(req.params.id).then(product => {
            return res.render('edit', { product })
        })
    },
    postEdit: function (req, res) {
        editProduct(req.body.id, req.body).then(() => {
            return res.redirect('/')
        })
    },
    getDelete: function (req, res) {
        let id = req.params.id
        return res.render('delete', { id })
    },
    postDelete: function (req, res) {
        deleteProduct(req.params.id).then(() => {
            return res.redirect('/')
        })
    }
};
