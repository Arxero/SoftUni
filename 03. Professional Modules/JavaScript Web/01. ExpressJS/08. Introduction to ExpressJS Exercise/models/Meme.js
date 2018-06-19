const mongoose = require('mongoose')

let memeSchema = mongoose.Schema({
    title: { type: mongoose.SchemaTypes.String, required: true},
    dateOfCreation: { type: mongoose.SchemaTypes.Date, required: true, default: Date.now },
    description: { type: mongoose.SchemaTypes.String, required: true},
    image: { type: mongoose.SchemaTypes.String, required: true},
    privacy: { type: mongoose.SchemaTypes.String},
    votes: { type: mongoose.SchemaTypes.Number, required: true, default: 0 },
})

module.exports = mongoose.model('Meme', memeSchema)