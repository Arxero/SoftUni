let express = require('express')
let app = express()
let port = 5000

app.get('/', (req, res) => {
    res.send('Hello from express!')
})

app.listen(port, () => console.log(`Listening on ${port}...`))