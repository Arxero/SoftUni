const User = require('../models/User')
const Product = require('../models/Product')
const donerdb = require('../database/donerdb')


module.exports.index = (req, res) => {
    Product.find().then(products => {
        if (products.length == 0) {
            Product.create(donerdb).then(() => {
                renderDoners(products)
            })
        } else {
            renderDoners(products)
        }

        function renderDoners(doners) {
            let data = {}
            data.chicken = ''
            for (let doner of doners.filter(x => x.category == 'Chicken')) {
                data.chicken += `<div class="product-card"><img src="${doner.image}"><a href="order/${doner._id}" class="button product-title">Order</a></div>`
            }
            data.beef = ''
            for (let doner of doners.filter(x => x.category == 'Beef')) {
                data.beef += `<div class="product-card"><img src="${doner.image}"><a href="order/${doner._id}" class="button product-title">Order</a></div>`
            }
            data.lamb = ''
            for (let doner of doners.filter(x => x.category == 'Lamb')) {
                data.lamb += `<div class="product-card"><img src="${doner.image}"><a href="order/${doner._id}" class="button product-title">Order</a></div>`
            }

            if (req.user) {
                data.username = req.user.username

                User.findOne({ username: data.username }).then(user => {
                    if (req.query.error) {
                        data.error = req.query.error
                    } else if (req.query.success) {
                        data.success = req.query.success
                    }

                    if (user.roles.includes('Admin')) {

                        data.chicken = ''
                        for (let doner of doners.filter(x => x.category == 'Chicken')) {
                            data.chicken += `
                            <div class="product-card">
                            <img src="${doner.image}">
                            <a href="edit/${doner._id}" class="control"><img class="control-img" src="public/images/edit.png"></a>
                            <a href="delete/${doner._id}" class="control"><img class="control-img" src="public/images/delete.png"></a>
                            </div>`
                        }
                        data.beef = ''
                        for (let doner of doners.filter(x => x.category == 'Beef')) {
                            data.beef += `
                            <div class="product-card">
                            <img src="${doner.image}">
                            <a href="edit/${doner._id}" class="control"><img class="control-img" src="public/images/edit.png"></a>
                            <a href="delete/${doner._id}" class="control"><img class="control-img" src="public/images/delete.png"></a>
                            </div>`
                        }
                        data.lamb = ''
                        for (let doner of doners.filter(x => x.category == 'Lamb')) {
                            data.lamb += `
                            <div class="product-card">
                            <img src="${doner.image}">
                            <a href="edit/${doner._id}" class="control"><img class="control-img" src="public/images/edit.png"></a>
                            <a href="delete/${doner._id}" class="control"><img class="control-img" src="public/images/delete.png"></a>
                            </div>`
                        }


                        res.render('home-admin', data)
                        return
                    } else {
                        res.render('home', data)
                        return
                    }
                })
            } else {
                if (req.query.error) {
                    data.error = req.query.error
                } else if (req.query.success) {
                    data.success = req.query.success
                }

                res.render('home', data)
                return
            }
        }
    })
}