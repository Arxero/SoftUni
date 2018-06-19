const mongoose = require('mongoose')

let schema = mongoose.Schema({
    creator: { type: mongoose.Schema.Types.ObjectId, required: true},
    product: { type: mongoose.Schema.Types.ObjectId, required: true, ref: 'Product'},
    date: {type: mongoose.Schema.Types.Date, required: true, default: Date.now},
    topings: [{ type: mongoose.Schema.Types.String}],
    status: { type: mongoose.Schema.Types.String, required: true, default: 'Pending'}
})

let Order = mongoose.model('Order', schema)

module.exports = Order