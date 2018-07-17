import React, { Component } from 'react'
import observer from '../../observer';
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"

export default class DeleteUser extends Component {
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
        let authtoken = this.props.authtoken
        let userId = this.props.match.params.id
        if (authtoken === '') {
            authtoken = sessionStorage.getItem('authtoken')
        }

        const AUTH_HEADERS = {
            'Content-Type': 'application/json',
            'Authorization': 'Kinvey ' + authtoken
        }

        fetch(BASE_URL + 'user/' + APP_KEY + '/' + userId + '?hard=true', {
            method: 'DELETE',
            headers: AUTH_HEADERS,
        }).then(res => {
             //console.log(res)
             observer.trigger(observer.events.notification, { type: 'success', message: 'User Deleted Successfully' })
             this.props.history.push("/users")
        })
    }

    render() {
        return (
            <form className="modal-content-profile" onSubmit={this.onFormSubmit}>
                <div className="container">
                    <h1>Delete {this.state.user.username}'s Profile</h1>
                    <img src={this.state.user.image} alt='noimage' />
                    <button type="submit" className="button">DELETE</button>
                </div>
            </form>
        )
    }
}