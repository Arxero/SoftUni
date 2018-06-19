module.exports.index = (req, res) => {
    let data = {}
    if (req.query.error) {
        data.error = req.query.error
    } else if (req.query.success) {
        data.success = req.query.success
    }

    res.render('home', data)
}

//let userId = req.user._id
//let username = req.user.username
//let productId = req.params.id
//compare user ids -> article.author.equals(userId)