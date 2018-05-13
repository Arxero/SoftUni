class Contact {
    constructor(firstName, lastName, phone, email) {
        this.firstName = firstName
        this.lastName = lastName
        this.phone = phone
        this.email = email
        this._online = false
        this._element = this.createElement()
    }

    set online(value) {
        this._online = value
        this.update()
    }
    get online() {
        return this._online
    }
    update() {
        if (this.online) {
            this._element.find('.title').addClass('online')
        } else {
            this._element.find('.title').removeClass('online')
        }
    }

    createElement() {
        let contact = $('<article>').append($('<div>')
            .append($('<div>').addClass('title').text(`${this.firstName} ${this.lastName}`)
                .append($('<button>').html('&#8505;').on('click', function () {
                    $(this).parent().next().toggle()
                }))
            )//end of first div   
            .append($('<div>').addClass('info').hide()
                .append($('<span>').html(`&phone; ${this.phone}`))
                .append($('<span>').html(`&#9993;; ${this.email}`))
            )//end of second div
        )//end of article
        return contact
    }

    render(id) {
        $(`#${id}`).append(this._element)
    }
}