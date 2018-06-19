const mongoose = require('mongoose')

let schemaArticle = mongoose.Schema({
    title: { type: mongoose.Schema.Types.String, required: true},
    status: { type: mongoose.Schema.Types.Boolean, required: true, default: false },
    date: {type: mongoose.Schema.Types.Date, required: true, default: Date.now},
    edits: [{ type: mongoose.Schema.Types.ObjectId, ref: 'Edit'}],
})

let Article = mongoose.model('Article', schemaArticle)

module.exports = Article