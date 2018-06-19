const staticHandler = require('./static')
const homeHandler = require('./home')
const aboutHandler = require('./about')
const dataHandler = require('./data')
const errorHandler = require('./error')

module.exports = [
    staticHandler,
    homeHandler,
    aboutHandler,
    dataHandler,
    errorHandler
]