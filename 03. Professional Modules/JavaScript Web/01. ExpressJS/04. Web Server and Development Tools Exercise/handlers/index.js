const homeHandler = require('./home')
const filesHandler = require('./static-files')
const viewAllHandler = require('./view-all')
const addMovieHandler = require('./add-movie')
const detailsHandler = require('./details')
const headerHandler = require('./header')
const errorHandler = require('./error')

module.exports = [
    homeHandler,
    filesHandler,
    viewAllHandler,
    addMovieHandler,
    detailsHandler,
    headerHandler,
    errorHandler,
]