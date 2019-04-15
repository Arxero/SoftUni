let Task = require('../models/Task')

function getAll() {
    let allTasks = Task.find({})
    return allTasks
}

function addTask(task) {
    return Task.create(task)
}

function findById(id) {
    return Task.findById(id)
}

function editTask(id, newTask) {
    return Task.findOneAndUpdate(id, newTask)
}

function deleteTask(id) {
    return Task.findOneAndDelete(id)
}

module.exports = {
    getIndex: function (req, res) {
        getAll().then(tasks => {
            let openTasks = []
            let inProgressTasks = []
            let finishedTasks = []
            tasks.forEach(x => {
                switch (x.status) {
                    case 'Open': openTasks.push(x); break
                    case 'In Progress': inProgressTasks.push(x); break
                    case 'Finished': finishedTasks.push(x); break
                }
            })
            return res.render('index', { openTasks, inProgressTasks, finishedTasks })
        })
    },
    getCreate: function (req, res) {
        return res.render('create')
    },
    postCreate: function (req, res) {
        addTask(req.body).then(() => {
            return res.redirect('/')
        })
    },
    getEdit: function (req, res) {
        findById(req.params.id).then(task => {
            switch (task.status) {
                case 'Open': task['open'] = true; break
                case 'In Progress': task['inProgress'] = true; break
                case 'Finished': task['finished'] = true; break
            }
            return res.render('edit', { task })
        })
    },
    postEdit: function (req, res) {
        editTask(req.params.id, req.body).then(() => {
            return res.redirect('/')
        })
    },
    getDelete: function (req, res) {
        findById(req.params.id).then(task => {
            switch (task.status) {
                case 'Open': task['open'] = true; break
                case 'In Progress': task['inProgress'] = true; break
                case 'Finished': task['finished'] = true; break
            }
            return res.render('delete', { task })
        })
    },
    postDelete: function (req, res) {
        deleteTask(req.params.id).then(() => {
            return res.redirect('/')
        })
    }
};