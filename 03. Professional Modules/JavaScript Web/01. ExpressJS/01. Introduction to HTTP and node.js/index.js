const fs = require('fs')
const Person = require('./Person')
const {update, getAll} = require('./api')
const myPerson = new Person('pesho', 22)
//console.log(myPerson.age);

update(0, myPerson)
update(1, new Person('gosho', 23))

fs.writeFileSync('./data.json', JSON.stringify(getAll()))
let text = fs.readFileSync('./package.json', 'utf8')
console.log(text);

