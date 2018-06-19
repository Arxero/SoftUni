const mongoose = require('mongoose')

let schema = mongoose.Schema({
    title: { type: mongoose.SchemaTypes.String, required: true },
    year: { type: mongoose.SchemaTypes.String, required: true },
    image: { type: mongoose.SchemaTypes.String, required: true },
    author: { type: mongoose.SchemaTypes.String, required: true },
    dateAdded: { type: mongoose.SchemaTypes.Date, required: true, default: Date.now },
})

module.exports = mongoose.model('Book', schema)