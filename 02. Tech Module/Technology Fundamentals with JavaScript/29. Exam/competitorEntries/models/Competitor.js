const mongoose = require('mongoose');

const competitorSchema = new mongoose.Schema({
    name: { type: String, required: true },
    age: { type: Number, required: true },
    team: { type: String, required: true },
    category: { type: String, required: true }
});

const Competitor = mongoose.model('Competitor', competitorSchema);
module.exports = Competitor;