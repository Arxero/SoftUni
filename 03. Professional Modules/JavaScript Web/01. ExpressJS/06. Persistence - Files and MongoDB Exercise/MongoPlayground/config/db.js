const mongoose = require('mongoose')
mongoose.Promise = global.Promise

require('../models/TagSchema')
require('../models/ImageSchema')

const connectionString = 'mongodb://localhost:27017/mongoplayground'

module.exports = mongoose.connect(connectionString)