const port = 5000
const config = require('./config/config')
const database = require('./config/dbConfig')
const express = require('express')

let app = express()
let enviroment = process.env.NODE_ENV || 'development'

database(config[enviroment])
require('./config/express')(app, config[enviroment])
require('./config/routes')(app)
app.listen(port)

console.log(`Listening on port ${port}...`)