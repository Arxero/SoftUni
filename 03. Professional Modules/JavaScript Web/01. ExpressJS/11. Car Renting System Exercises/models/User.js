const mongoose = require('mongoose')
const encryption = require('../utilities/encryption')


let userSchema = mongoose.Schema({
    username: {
        type: mongoose.Schema.Types.String,
        required: true,
        unique: true
    },
    password: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    salt: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    roles: [{ type: mongoose.Schema.Types.String }],
    rentedCars: [{
        id: { type: mongoose.Schema.Types.ObjectId, ref: 'Car' },
        make: { type: mongoose.Schema.Types.String},
        model: { type: mongoose.Schema.Types.String},
        duration: { type: mongoose.Schema.Types.String }
    }]

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
                salt: salt,
                password: hashedPass,
                roles: ['Admin']
            })
        }
    })
}

module.exports.seedNormalUser = () => {
    User.find({ username: 'user' }).then(users => {
        if (users.length === 0) {
            let salt = encryption.generateSalt()
            let hashedPass = encryption.generateHashedPassword(salt, 'password')
            User.create({
                username: 'user',
                salt: salt,
                password: hashedPass,
                roles: ['User']
            })
        }
    })
}