const User = require('../models/User')
const Article = require('../models/Article')


module.exports.createGet = (req, res) => {
    res.render('article/create')
}

module.exports.createPost = (req, res) => {
    let article = req.body
    article.image = '\\' + req.file.path
    article.author = req.user._id
    //console.log(article)

    Article.create(article).then((createdArticle) => {
        User.findById(article.author).then((user) => {
            user.articles.push(createdArticle)
            user.save()
        })
        res.redirect('/')
    })
}

module.exports.details = (req, res) => {
    let articleId = req.params.id
    let username = req.user.username

    Article.findById(articleId).populate('author').then(article => {
        if (username == 'admin') {
            article.isUserAuthorized = true
        }

        res.render('article/details', { article })
    })
}

module.exports.deleteGet = (req, res) => {
    let articleId = req.params.id

    Article.findById(articleId).then(article => {
        res.render('article/delete', article)
    })
}

module.exports.deletePost = (req, res) => {
    let articleId = req.params.id

    Article.deleteOne({ _id: articleId }).then(() => {
        res.redirect('/?success=' + encodeURIComponent('Article was deleted successfully!'))
    })
}

module.exports.editGet = (req, res) => {
    let articleId = req.params.id

    Article.findById(articleId).then(article => {
        res.render('article/edit', article)
    })
}

module.exports.editPost = (req, res) => {
    let articleId = req.params.id
    let editedArticle = req.body
    let userId = req.user._id

    Article.findById(articleId).then(article => {
        if (article.author.equals(userId)) {
            article.title = editedArticle.title
            article.content = editedArticle.content
            article.author = userId

            if (req.file) {
                article.image = '\\' + req.file.path
            }

            article.save().then(() => {
                res.redirect('/?success=' + encodeURIComponent('Article edited successfully!'))
                return
            })

        } else {
            res.redirect('/?success=' + encodeURIComponent('You are not the author of the article!'))
            return
        }
    })
}