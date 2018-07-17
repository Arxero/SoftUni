import React, { Component } from 'react'
import observer from '../../observer';
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"
const ROLE = '3997924e-436c-495d-a181-d6af1ba20eb4'
const APP_MASTER_SECRET = '06e612c201b44ec9b7d9ed365d94f184'
const AUTH_HEADERS = {
    'Content-Type': 'application/json',
    'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_MASTER_SECRET)
}

export default class AdminUser extends Component {
    constructor(props) {
        super(props)
        this.state = {
            user: {
                image: this.props.location.image,
                status: this.props.location.status,
                username: this.props.location.username,
                email: this.props.location.email
            }
        }
    }
    onFormSubmit = ev => {
        ev.preventDefault()
        let userId = this.props.match.params.id

        fetch(BASE_URL + 'user/' + APP_KEY + '/' + userId + '/roles/' + ROLE, {
            method: 'PUT',
            headers: AUTH_HEADERS,
            body: JSON.stringify({})
        }).then(res => {
             //console.log(res)
             observer.trigger(observer.events.notification, { type: 'success', message: 'User has been turned into Admin Successfully' })
             this.props.history.push("/users")
        })
    }

    render() {
        return (
            <form className="modal-content-profile" onSubmit={this.onFormSubmit}>
                <div className="container">
                    <h1>Make {this.state.user.username} Admin</h1>
                    <img src={this.state.user.image} alt='noimage' />
                    <button type="submit" className="button">SUBMIT</button>
                </div>
            </form>
        )
    }
}