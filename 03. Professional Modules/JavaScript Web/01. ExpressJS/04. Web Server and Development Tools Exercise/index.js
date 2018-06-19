const http = require('http')
const handlers = require('./handlers')
const port = 5000

http.createServer((req, res) => {
    for (let handler of handlers) {
        if (handler(req, res) != true) {
            break
        }
    }
}).listen(port)

console.log(`Listening on port ${port}...`);