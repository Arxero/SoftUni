const User = require('../models/User')
const Article = require('../models/Article')
const Edit = require('../models/Edit')


module.exports.latestArticleGet = (req, res) => {

    Article.find().then(articles => {
        let data = {}
        if (req.user) {
            data.email = req.user.email
        }
        let articleId = articles.reverse()[0]._id
        Edit.find({ article: articleId }).then(edit => {
            res.render('article/latest-article', { data, title: articles[0].title, content: edit.reverse()[0].content, id: articles[0]._id })
        })
    })
}

module.exports.allArticlesGet = (req, res) => {
    Article.find().then(articles => {
        articles.sort((a, b) => a.title > b.title)
        let data = {}
        if (req.user) {
            data.email = req.user.email
        }
        res.render('article/all-articles', { data, articles })
    })

}

module.exports.createGet = (req, res) => {
    let data = {}
    if (req.user) {
        data.email = req.user.email
    }
    res.render('article/create', { data })
}

module.exports.createPost = (req, res) => {
    let article = req.body
    let editToBeAdded = {
        author: req.user.email,
        content: req.body.content
    }

    Article.create({ title: article.title }).then(article => {
        Edit.create(editToBeAdded).then(edit => {
            article.edits.push(edit._id)
            edit.article = article._id
            article.save()
            edit.save().then(() => {
                res.redirect('/?success=' + encodeURIComponent('Article added Successfully!'))
            })
        })
    })
}

module.exports.viewArticle = (req, res) => {
    let articleId = req.params.id

    Article.findById(articleId).then(article => {
        let data = {}
        if (req.user) {
            data.email = req.user.email
        }

        Edit.find({ article: articleId }).then(edit => {
            res.render('article/latest-article', { data, title: article.title, content: edit.reverse()[0].content, id: article._id })
        })
    })
}

module.exports.editArticleGet = (req, res) => {
    let userId = req.user._id
    let articleId = req.params.id

    User.findById(userId).then(user => {
        let data = {}

        if (req.user) {
            if (user.roles.includes('Admin')) {
                data.isAdmin = true
                data.email = req.user.email
            } else {
                data.email = req.user.email
            }
        }

        Article.findById(articleId).then(article => {
            Edit.find({ article: articleId }).then(edits => {
                res.render('article/edit', { data, title: article.title, content: edits.reverse()[0].content, id: articleId })
            })
        })
    })
}

module.exports.editArticlePost = (req, res) => {
    let editedArticle = req.body
    let articleId = req.params.id
    let user = req.user.email


    Article.findById(articleId).then(article => {
        let newEdit = {
            author: user,
            content: editedArticle.content,
            article: article._id
        }

        Edit.create(newEdit).then(edit => {
            article.edits.push(edit._id)
            article.save().then(() => {
                res.redirect('/?success=' + encodeURIComponent('Article edited Successfully!'))
            })
        })
    })
}

module.exports.history = (req, res) => {
    let articleId = req.params.id

    Article.findById(articleId).then(article => {
        Edit.find({ article: articleId }).then(edits => {
            let data = {}
            if (req.user) {
                data.email = req.user.email
            }
            edits = edits.reverse()
            res.render('article/history', { data, edits, title: article.title })
        })
    })
}

module.exports.viewEdit = (req, res) => {
    let editId = req.params.id

    Edit.findById(editId).then(edit => {
        let data = {}
        if (req.user) {
            data.email = req.user.email
        }

        res.render('article/view-edit', { data, content: edit.content })
    })
}

module.exports.lockArticle = (req, res) => {
    let articleId = req.params.id

    Article.findById(articleId).then(article => {
        article.status = true
        article.save().then(() => {
            res.redirect('/?success=' + encodeURIComponent('Article locked Successfully!'))
        })
    })
}

module.exports.unlockArticle = (req, res) => {
    let articleId = req.params.id

    Article.findById(articleId).then(article => {
        article.status = false
        article.save().then(() => {
            res.redirect('/?success=' + encodeURIComponent('Article unlocked Successfully!'))
        })
    })
}




