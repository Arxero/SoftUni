const User = require('../models/User')
const Product = require('../models/Product')
const Order = require('../models/Order')


module.exports.createGet = (req, res) => {
    res.render('product/create', { username: req.user.username })
}

module.exports.createPost = (req, res) => {
    let product = req.body

    if (product.category == 'Chicken' || product.category == 'Lamb' || product.category == 'Beef') {
        if (Number(product.size) >= 17 && Number(product.size <= 24)) {
            product.topings = product.topings.split(',').map(x => x.trim()).filter(x => x != '')
            product.user = req.session.passport.user

            if (product.topings.includes('pickle') ||
                product.topings.includes('tomato') ||
                product.topings.includes('onion') ||
                product.topings.includes('lettuce') ||
                product.topings.includes('hot sauce') ||
                product.topings.includes('extra sauce')) {

                Product.create(product).then(() => {
                    res.redirect('/?success=' + encodeURIComponent('Product was added Succesfully!'))
                    return
                })
            }
        }
    } else {
        res.redirect('product/create/?error=' + encodeURIComponent('Error'))
    }
}

module.exports.orderGet = (req, res) => {
    let donerId = req.params.id

    Product.findById(donerId).then(doner => {
        res.render('product/order', { image: doner.image, category: doner.category, size: doner.size, topings: doner.topings, username: req.user.username })
    })
}

module.exports.orderGet = (req, res) => {
    let donerId = req.params.id

    Product.findById(donerId).then(doner => {
        res.render('product/order', { image: doner.image, category: doner.category, size: doner.size, topings: doner.topings, username: req.user.username })
    })
}


module.exports.orderPost = (req, res) => {
    let product = req.params.id
    let creator = req.user._id

    let topings = []

    for (let toping of Object.keys(req.body)) {
        topings.push(toping)
    }
    let order = {
        product,
        creator,
        topings
    }

    Order.create(order).then((createdOrder) => {
        res.redirect(`/order/details/${createdOrder._id}`)
    })
}

module.exports.detailsGet = (req, res) => {
    let orderId = req.params.id

    Order.findById(orderId).populate('product').then(order => {

        order = {
            creator: order.creator,
            product: order.product,
            date: order.date.toString().slice(0, 21),
            topings: order.topings,
            status: order.status,
            _id: order._id
        }

        switch (order.status) {
            case 'pending': order.pending = true
                break
            case 'inProgress':
                order.inProgress = true
                break
            case 'inTransit':
                order.inTransit = true
                break
            case 'delivered':
                order.delivered = true
                break
        }

        res.render('product/details', { username: req.user.username, order })
    })
}

module.exports.statusGet = (req, res) => {
    let userId = req.user._id

    User.findById(userId).then(user => {
        if (user.roles.includes('Admin')) {
            Order.find().populate('product').then(orders => {
                orders = orders.map(order => ({
                    creator: order.creator,
                    product: order.product,
                    date: order.date.toString().slice(0, 21),
                    topings: order.topings,
                    status: order.status,
                    _id: order._id
                }))

                for (let order of orders) {
                    switch (order.status) {
                        case 'pending': order.pending = true
                            break
                        case 'inProgress':
                            order.inProgress = true
                            break
                        case 'inTransit':
                            order.inTransit = true
                            break
                        case 'delivered':
                            order.delivered = true
                            break
                    }
                }

                res.render('product/status-admin', { orders, username: req.user.username })
            })
        } else {
            Order.find({ creator: userId }).populate('product').then(orders => {
                orders = orders.map(order => ({
                    creator: order.creator,
                    product: order.product,
                    date: order.date.toString().slice(0, 21),
                    topings: order.topings,
                    status: order.status,
                    _id: order._id
                }))

                res.render('product/status', { orders, username: req.user.username })
            })
        }
    })
}

module.exports.statusPost = (req, res) => {
    let ordersId = []
    for (let order of Object.keys(req.body)) {
        ordersId.push(order)
    }

    Order.find({ _id: ordersId }).then(orders => {
        let count = 1
        for (let order of orders) {
            order.status = req.body[order.id]
            order.save()

            if (count == orders.length) {
                res.redirect('/?success=' + encodeURIComponent('Changes saved Successfully!'))
            }
            count++
        }
    })
}

module.exports.deleteGet = (req, res) => {
    let productId = req.params.id

    Product.findById(productId).then(product => {
        res.render('product/delete', { product, username: req.user.username })
    })
}

module.exports.deletePost = (req, res) => {
    let productId = req.params.id

    Product.deleteOne({ _id: productId }).then(product => {
        res.redirect('/?success=' + encodeURIComponent('Product deleted Successfully!'))
    })
}

module.exports.editGet = (req, res) => {
    let productId = req.params.id

    Product.findById(productId).then(product => {
        res.render('product/edit', { product, username: req.user.username })
    })
}

module.exports.editPost = (req, res) => {
    let productId = req.params.id
    let productEdited = req.body

    Product.findById(productId).then(product => {

        if (Number(productEdited.size) >= 17 && Number(productEdited.size <= 24)) {
            productEdited.topings = productEdited.topings.split(',').map(x => x.trim()).filter(x => x != '')
            product.user = req.session.passport.user

            if (productEdited.topings.includes('pickle') ||
                productEdited.topings.includes('tomato') ||
                productEdited.topings.includes('onion') ||
                productEdited.topings.includes('lettuce') ||
                productEdited.topings.includes('hot sauce') ||
                productEdited.topings.includes('extra sauce')) {

                    product.category = productEdited.category
                    product.size = productEdited.size
                    product.image = productEdited.image
                    product.topings = productEdited.topings
                    product.save().then(() => {
                        res.redirect('/?success=' + encodeURIComponent('Product edited Successfully!'))
                    })
            }
        }
    })
}