const mongoose = require('mongoose')

let catSchema = new mongoose.Schema({
    name: { type: String, required: true },
    age: { type: Number, required: true },
    color: { type: String },
})

catSchema.methods.sayHello = function () {
    return `Hello from ${this.name}`
}

let Cat = mongoose.model('Cat', catSchema)



mongoose
    .connect('mongodb://localhost:27017/cats')
    .then(() => {
        Cat.findOne().then(cat => console.log(cat.sayHello()))
    })