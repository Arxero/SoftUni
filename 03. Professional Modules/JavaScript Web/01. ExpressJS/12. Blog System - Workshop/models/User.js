const mongoose = require('mongoose')
const encryption = require('../utilities/encryption')
const propertyIsRequired = '{0} is required.'

let userSchema = mongoose.Schema({
    username: {
        type: mongoose.Schema.Types.String,
        required: propertyIsRequired.replace('{0}', 'Username'),
        unique: true
    },
    password: {
        type: mongoose.Schema.Types.String,
        required: propertyIsRequired.replace('{0}', 'Password')
    },
    email: {
        type: mongoose.Schema.Types.String,
        required: propertyIsRequired.replace('{0}', 'Email'),
        unique: true
    },
    salt: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    fullName: {
        type: mongoose.Schema.Types.String,
        required: propertyIsRequired.replace('{0}', 'Name')
    },
    date: {type: mongoose.Schema.Types.Date, required: true, default: Date.now},
    roles: [{ type: mongoose.Schema.Types.String }],
    articles: [{ type: mongoose.Schema.Types.ObjectId, default: [], ref: 'Article' }]
})

userSchema.method({
    authenticate: function (password) {
        let hashedPassword = encryption.generateHashedPassword(this.salt, password)
        if (hashedPassword === this.password) {
            return true
        }
        return false
    }
})
const User = mongoose.model('User', userSchema)
module.exports = User

module.exports.seedAdminUser = () => {
    User.find({ username: 'admin' }).then(users => {
        if (users.length === 0) {
            let salt = encryption.generateSalt()
            let hashedPass = encryption.generateHashedPassword(salt, 'admin')
            User.create({
                username: 'admin',
                fullName: 'Maverick Cloud',
                salt: salt,
                password: hashedPass,
                email: 'admin@syntrwave.com',
                roles: ['Admin']
            })
        }
    })
}