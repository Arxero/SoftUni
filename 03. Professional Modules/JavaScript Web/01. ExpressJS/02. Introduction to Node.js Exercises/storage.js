const fs = require('fs')
const path = require('path')
const storagePath = path.join(__dirname, '/storage.json')
let data = {}

function put(key, value) {
    if (typeof key != 'string') {
        throw new Error('The Key is not a string!')
    }
    if (data.hasOwnProperty(key)) {
        throw new Error('The Key already exist!')
    }
    data[key] = value
}

function get(key) {
    if (typeof key != 'string') {
        throw new Error('The Key is not a string!')
    }
    if (!data.hasOwnProperty(key)) {
        throw new Error('The Key does not exist!')
    }
    return data[key]
}

function getAll() {
    if (Object.keys(data).length == 0) {
        return 'There are no items in the storage'
    }
    return data
}

function update(key, newValue) {
    if (typeof key != 'string') {
        throw new Error('The Key is not a string!')
    }
    if (!data.hasOwnProperty(key)) {
        throw new Error('The Key does not exist!')
    }
    return data[key] = newValue
}

function deleteItem(key) {
    if (typeof key != 'string') {
        throw new Error('The Key is not a string!')
    }
    if (!data.hasOwnProperty(key)) {
        throw new Error('The Key does not exist!')
    }
    return delete data[key]
}


function clear() {
    data = {}
}

function save() {
    if (!fs.existsSync(storagePath)) {
        fs.writeFileSync(storagePath, '[]')
    }
    let json = JSON.stringify(data)
    fs.writeFileSync(storagePath, json)
}

function load() {
    if (fs.existsSync(storagePath)) {
        let json = fs.readFileSync(storagePath).toString()
        let storage = JSON.parse(json)
        return data = storage
    }
}

module.exports = {
    put,
    save,
    load,
    get,
    getAll,
    delete : deleteItem,
    update,
    clear,
}