const mongoose = require('mongoose')

let schemaArticle = mongoose.Schema({
    title: { type: mongoose.Schema.Types.String, required: true },
    content: { type: mongoose.Schema.Types.String, required: true },
    date: {type: mongoose.Schema.Types.Date, required: true, default: Date.now},
    image: { type: mongoose.Schema.Types.String },
    author: { type: mongoose.Schema.Types.ObjectId, ref: 'User', required: true },
})

let Article = mongoose.model('Article', schemaArticle)

module.exports = Article