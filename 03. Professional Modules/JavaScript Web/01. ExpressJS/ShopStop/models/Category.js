const mongoose = require('mongoose')

let categorySchema = mongoose.Schema({
    name: { type: mongoose.Schema.Types.String, required: true },
    creator: { type: mongoose.Schema.Types.ObjectId, ref: 'User', required: true },
    products: [{ type: mongoose.Schema.Types.ObjectId, ref: 'Product' }]
})

let Categoty = mongoose.model('Category', categorySchema)

module.exports = Categoty