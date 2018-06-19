const Article = require('../models/Article')
const Edit = require('../models/Edit')


module.exports.index = (req, res) => {
    

    Article.findOne({}, {}, { sort: { date: -1 } }).then(article => {
        Edit.find({ article: article._id }).then(edits => {

            let data = {}
            if (req.user) {
                data.email = req.user.email
            }

            if (req.query.error) {
                data.error = req.query.error
            } else if (req.query.success) {
                data.success = req.query.success
            }

            Article.find().then(allArticles => {
                allArticles = allArticles.reverse()
                res.render('home', {data, allArticles, title: article.title, content: edits.reverse()[0].content, id: allArticles[0]._id})
            })

        })
    })
}

//let userId = req.user._id
//let username = req.user.username
//let productId = req.params.id
//compare user ids -> article.author.equals(userId)