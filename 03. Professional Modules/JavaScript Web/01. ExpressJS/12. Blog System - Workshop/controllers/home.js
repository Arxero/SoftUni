const Article = require('../models/Article')

module.exports.index = (req, res) => {
    let queryData = req.query
    Article.find().populate('author').then((articles) => {
        if (queryData.query) {
            articles = articles.filter(x => x.title.toLowerCase().includes(queryData.query))
        }

        let data = { articles: articles }
        if (req.query.error) {
            data.error = req.query.error
        } else if (req.query.success) {
            data.success = req.query.success
        }

        res.render('home', data)
    })
}