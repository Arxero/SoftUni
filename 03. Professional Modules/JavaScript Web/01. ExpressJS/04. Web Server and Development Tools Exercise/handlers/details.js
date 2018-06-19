const url = require('url')
const fs = require('fs')
const path = require('path')
const db = require('../config/dataBase')

module.exports = (req, res) => {
    req.pathname = req.pathname || url.parse(req.url).pathname
    let movieNumber = Number(req.pathname.split('/').pop())

    if (req.pathname.startsWith('/movies/details/') && req.method == 'GET' && movieNumber >= 1 &&movieNumber <= db.length) {
        let filePath = path.normalize(path.join(__dirname, '../views/details.html'))

        fs.readFile(filePath, (err, data) => {
            if (err) {
                console.log(err)
                res.writeHead(404, {
                    'content-type': 'text/plain'
                })
                res.write('Not Found')
                res.end()
                return
            }
            let selectedMovie = db[movieNumber - 1]
            let content = `
            <div class="content">
                <img src="${decodeURIComponent(selectedMovie.moviePoster)}" alt=""/>
                <h3>Title  ${decodeURIComponent(selectedMovie.movieTitle).split('+').join(' ')}</h3>
                <h3>Year ${decodeURIComponent(selectedMovie.movieYear).split('+').join(' ')}</h3>
                <p> ${decodeURIComponent(selectedMovie.movieDescription).split('+').join(' ')}</p>
            </div>​`

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