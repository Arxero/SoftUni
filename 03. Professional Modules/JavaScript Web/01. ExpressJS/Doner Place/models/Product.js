const mongoose = require('mongoose')

let schemaProduct = mongoose.Schema({
    category: { type: mongoose.Schema.Types.String, required: true},
    size: { type: mongoose.Schema.Types.String, required: true },
    date: {type: mongoose.Schema.Types.Date, required: true, default: Date.now},
    image: { type: mongoose.Schema.Types.String },
    topings: [{ type: mongoose.Schema.Types.String}],
})

let Product = mongoose.model('Product', schemaProduct)

module.exports = Product