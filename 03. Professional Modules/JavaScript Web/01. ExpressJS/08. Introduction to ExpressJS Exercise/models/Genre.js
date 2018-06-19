const mongoose = require('mongoose')

let genreSchema = mongoose.Schema({
    genreName: { type: mongoose.SchemaTypes.String, required: true },
    memeList: [{ type: mongoose.SchemaTypes.ObjectId }],
})

module.exports = mongoose.model('Genre', genreSchema)