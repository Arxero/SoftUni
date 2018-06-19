const mongoose = require('mongoose')

let schemaEdit = mongoose.Schema({
    author: { type: mongoose.Schema.Types.String, required: true},
    date: {type: mongoose.Schema.Types.Date, required: true, default: Date.now},
    content: { type: mongoose.Schema.Types.String, required: true},
    article: { type: mongoose.Schema.Types.ObjectId, ref: 'Article'},
})

let Edit = mongoose.model('Edit', schemaEdit)

module.exports = Edit