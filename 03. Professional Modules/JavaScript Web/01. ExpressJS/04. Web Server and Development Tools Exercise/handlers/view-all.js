const url = require('url')
const fs = require('fs')
const path = require('path')
const db = require('../config/dataBase')

module.exports = (req, res) => {
    req.pathname = req.pathname || url.parse(req.url).pathname

    if (req.pathname.startsWith('/viewAllMovies') && req.method == 'GET') {
        let filePath = path.normalize(path.join(__dirname, `../views/viewAll.html`))

        fs.readFile(filePath, (err, data) => {
            if (err) {
                console.log(err);
                res.writeHead(404, {
                    'content-type': 'text/plain'
                })
                res.write('Resource not found!')
                res.end()
                return
            }
            let content = ''
            let count = 1
            for (let movie of db) {
                content += `
                <div class="movie">
                    <a href="/movies/details/${count++}"><img class="moviePoster" src="${decodeURIComponent(movie.moviePoster)}"/></a>
                </div>    
                `
            }
            let html = data.toString().replace('<div id="replaceMe">{{replaceMe}}</div>', content)

            res.writeHead(200, {
                'content-type': 'text/html'
            })
            res.write(html)
            res.end()
        })
    }else {
        return true
    }
}