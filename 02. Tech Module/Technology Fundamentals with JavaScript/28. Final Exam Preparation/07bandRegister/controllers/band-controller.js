const Band = require('../models/Band');

module.exports = {
    getIndex: function (req, res) {
        Band.find({}).then(bands => {
            return res.render('index', { bands })
        })
    },
    getCreate: function (req, res) {
        return res.render('create')
    },
    postCreate: function (req, res) {
        Band.create(req.body).then(() => {
            return res.redirect('/')
        })
    },
    getEdit: function (req, res) {
        Band.findById(req.params.id).then(band => {
            return res.render('edit', { band })
        })
    },
    postEdit: function (req, res) {
        Band.findByIdAndUpdate(req.params.id, req.body).then(() => {
            return res.redirect('/')
        })
    },
    getDelete: function (req, res) {
        Band.findByIdAndRemove(req.params.id).then(band => {
            return res.render('delete', { band })
        })
    },
    postDelete: function (req, res) {
        Band.findOneAndRemove(req.params.id).then(() => {
            return res.redirect('/')
        })
    }
};