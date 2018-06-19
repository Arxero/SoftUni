module.exports = (req, res) => {
    res.writeHead(404, {
        'content-type': 'text/plain'
    })
    res.write('Something went wrong :(')
    res.end()
}