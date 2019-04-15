const Competitor = require('../models/Competitor');

module.exports = {
    getIndex: function (req, res) {
        Competitor.find({}).then(competitors => {
            return res.render('index', { competitors })
        })
    },
    getCreate: function (req, res) {
        return res.render('create')
    },
    postCreate: function (req, res) {
        Competitor.create(req.body).then(() => {
            return res.redirect('/')
        })
    },
    getEdit: function (req, res) {
        Competitor.findById(req.params.id).then(competitor => {
            return res.render('edit', { competitor })
        })
    },
    postEdit: function (req, res) {
        Competitor.findOneAndUpdate(req.params.id, req.body).then(() => {
            return res.redirect('/')
        })
    },
    getDelete: function (req, res) {
        Competitor.findById(req.params.id).then(competitor => {
            return res.render('delete', { competitor })
        })
    },
    postDelete: function (req, res) {
        Competitor.findOneAndRemove(req.params.id).then(() => {
            return res.redirect('/')
        })
    }
};