const mongoose = require('mongoose')

let schema = mongoose.Schema({
    make: { type: mongoose.SchemaTypes.String, required: true },
    model: { type: mongoose.SchemaTypes.String, required: true },
    color: { type: mongoose.SchemaTypes.String, required: true },
    imageUrl: { type: mongoose.SchemaTypes.String, required: true },
    dailyPrice: { type: mongoose.SchemaTypes.Number, required: true },
    rentedCount: { type: mongoose.SchemaTypes.Number, required: true, default: 0 },
    isItRented: { type: mongoose.SchemaTypes.Boolean, required: true, default: false },
})

let Car = mongoose.model('Car', schema)
module.exports = Car