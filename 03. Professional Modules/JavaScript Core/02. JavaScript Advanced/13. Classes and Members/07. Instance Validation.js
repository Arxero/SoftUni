class CheckingAccount {
    constructor(clientId, email, firstName, lastName) {
        this.clientId = clientId
        this.email = email
        this.firstName = firstName
        this.lastName = lastName
        this.products = []
    }

    set clientId(id) {
        if (/^[0-9]{6}$/.test(id)) {
            this._clientId = id
        } else {
            throw new TypeError('Client ID must be a 6-digit number')
        }
    }
    get clientId() {
        return this._clientId
    }

    set email(em) {
        if (/^\w+@[a-zA-Z.]+$/.test(em)) {
            this._email = em
        } else {
            throw new TypeError('Invalid e-mail')
        }
    }
    get email() {
        return this._email
    }

    set firstName(fN) {
        if (fN.length >= 3 && fN.length <= 20) {
            if (/^[a-zA-Z]+$/.test(fN)) {
                this._firstName = fN
            } else {
                throw new TypeError('First name must contain only Latin characters')
            }
        } else {
            throw new TypeError('First name must be between 3 and 20 characters long')
        }
    }
    get firstName() {
        return this._firstName
    }

    set lastName(lN) {
        if (lN.length >= 3 && lN.length <= 20) {
            if (/^[a-zA-Z]+$/.test(lN)) {
                this._lastName = lN
            } else {
                throw new TypeError('Last name must contain only Latin characters')
            }
        } else {
            throw new TypeError('Last name must be between 3 and 20 characters long')
        }
    }
    get firstName() {
        return this._lastName
    }

}

// let test = new CheckingAccount('188314', 'ivan@some.com', 'Ivan', 'Petrov')
// console.log(test._clientId);
