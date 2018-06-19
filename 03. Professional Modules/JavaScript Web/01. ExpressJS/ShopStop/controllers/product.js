const Product = require('../models/Product')
const Category = require('../models/Category')
const fs = require('fs')

module.exports.addGet = (req, res) => {
    Category.find().then((categories) => {
        res.render('product/add', { categories: categories })
    })
}

module.exports.addPost = (req, res) => {
    let productObj = req.body
    productObj.image = '\\' + req.file.path
    productObj.creator = req.user._id

    Product.create(productObj).then((product) => {
        Category.findById(product.category).then((category) => {
            category.products.push(product._id)
            category.save()
        })
        res.redirect('/')
    })
}

module.exports.editGet = (req, res) => {
    let id = req.params.id
    Product.findById(id).then((product) => {
        if (!product || product.buyer != null) {
            res.sendStatus(404)
            return
        }

        if (product.creator.equals(req.user._id) || req.user.roles.indexOf('Admin') >= 0) {
            Category.find().then((categories) => {
                res.render('product/edit', { product, categories })
            })
        } else {
            res.redirect('/user/login')
        }
    })
}

module.exports.editPost = (req, res) => {
    let id = req.params.id
    let editedProduct = req.body

    Product.findById(id).then((product) => {
        if (!product || product.buyer != null) {
            res.redirect(`/?error=${encodeURIComponent('error=Product was not found!')}`)
            return
        }

        if (product.creator.equals(req.user._id) || req.user.roles.indexOf('Admin') >= 0) {

            product.name = editedProduct.name
            product.description = editedProduct.description
            product.price = editedProduct.price

            if (req.file) {
                product.image = '\\' + req.file.path
            }
            //First we check if the category is changed.
            if (product.category.toString() !== editedProduct.category) {
                //If so find the "current" and "next" category.
                Category.findById(product.category).then((currentCategory) => {
                    Category.findById(editedProduct.category).then((nextCategory) => {
                        let index = currentCategory.products.indexOf(product._id)
                        if (index >= 0) {
                            //Remove product specified from current category's list of products.
                            currentCategory.products.splice(index, 1)
                        }
                        currentCategory.save()

                        //Add product's reference to the "new" category.
                        nextCategory.products.push(product._id)
                        nextCategory.save()

                        product.category = editedProduct.category
                        product.save().then(() => {
                            res.redirect('/?success=' + encodeURIComponent('Product was edited successfully!'))
                        })
                    })
                })
            } else {
                product.save().then(() => {
                    res.redirect('/?success=' + encodeURIComponent('Product was edited successfully!'))
                })
            }
        } else {
            res.redirect('/user/login')
        }
    })
}

module.exports.deleteGet = (req, res) => {
    let id = req.params.id

    Product.findById(id).then((product) => {
        if (!product || product.buyer != null) {
            res.sendStatus(404)
            return
        }

        if (product.creator.equals(req.user._id) || req.user.roles.indexOf('Admin') >= 0) {
            res.render('product/delete', { product })
        } else {
            res.redirect('/user/login')
        }
    })
}

module.exports.deletePost = (req, res) => {
    let id = req.params.id

    Product.findOne({ _id: id }).then((product) => {
        if (!product || product.buyer != null) {
            res.redirect(`/?error=${encodeURIComponent('error=Product was not found!')}`)
            return
        }

        if (product.creator.equals(req.user._id) || req.user.roles.indexOf('Admin') >= 0) {

            Category.findById(product.category).then((category) => {
                let index = category.products.indexOf(product._id)
                if (index >= 0) {
                    //Remove product specified from category's list of products.
                    category.products.splice(index, 1)
                }
                Product.deleteOne({ _id: id }).then(() => {
                    fs.unlink('.' + product.image, (err, data) => {
                        if (err) {
                            console.log(err)
                        }
                    })
                    res.redirect('/?success=' + encodeURIComponent('Product was deleted successfully!'))
                    category.save()
                })
            })
        } else {
            res.redirect('/user/login')
        }
    })
}

module.exports.buyGet = (req, res) => {
    let id = req.params.id

    Product.findById(id).then((product) => {
        if (!product || product.buyer != null) {
            res.sendStatus(404)
            return
        }

        res.render('product/buy', { product })
    })
}

module.exports.buyPost = (req, res) => {
    let productId = req.params.id

    Product.findById(productId).then((product) => {
        if (product.buyer) {
            let error = `error=${encodeURIComponent('Product was already bought!')}`
            res.redirect(`/?${error}`)
            return
        }

        product.buyer = req.user._id
        product.save().then(() => {
            req.user.boughtProducts.push(productId)
            req.user.save().then(() => {
                res.redirect('/')
            })
        })
    })
}