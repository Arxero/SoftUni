const Game = require('../models/Game');

module.exports = {
    getIndex: function (req, res) {
        Game.find({}).then(games => {
            return res.render('index', { games })
        })
    },
    getCreate: function (req, res) {
        return res.render('create')
    },
    postCreate: function (req, res) {
        Game.create(req.body).then(() => {
            return res.redirect('/')
        })
    },
    getEdit: function (req, res) {
        Game.findById(req.params.id).then(game => {
            return res.render('edit', { game })
        })
    },
    postEdit: function (req, res) {
        Game.findOneAndUpdate(req.params.id, req.body).then(() => {
            return res.redirect('/')
        })
    },
    getDelete: function (req, res) {
        Game.findById(req.params.id).then(game => {
            return res.render('delete', { game })
        })
    },
    postDelete: function (req, res) {
        Game.findByIdAndRemove(req.params.id).then(() => {
            return res.redirect('/')
        })
    }
};