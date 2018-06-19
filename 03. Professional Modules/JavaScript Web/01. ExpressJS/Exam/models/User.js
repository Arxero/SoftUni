const mongoose = require('mongoose')
const encryption = require('../utilities/encryption')
const propertyIsRequired = '{0} is required.'


let userSchema = mongoose.Schema({
    email: {
        type: mongoose.Schema.Types.String,
        required: propertyIsRequired.replace('{0}', 'Email'),
        unique: true
    },
    password: {
        type: mongoose.Schema.Types.String,
        required: propertyIsRequired.replace('{0}', 'Password')
    },
    salt: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    roles: [{ type: mongoose.Schema.Types.String, default: 'User' }],
    articles: [{ type: mongoose.Schema.Types.ObjectId, ref: 'Article', default: []}],
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
    User.find({ email: 'admin@syntrwave.com' }).then(users => {
        if (users.length === 0) {
            let salt = encryption.generateSalt()
            let hashedPass = encryption.generateHashedPassword(salt, 'admin')
            User.create({
                email: 'admin@syntrwave.com',
                password: hashedPass,
                salt: salt,
                roles: ['Admin']
            })
        }
    })
}