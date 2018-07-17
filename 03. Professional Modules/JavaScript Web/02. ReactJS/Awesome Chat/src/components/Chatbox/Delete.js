import React, { Component } from 'react'
import observer from '../../observer';
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"


export default class Delete extends Component {
    constructor(props) {
        super(props)

        this.state = {
            message: {
                author: this.props.location.author,
                image: this.props.location.image,
                content: this.props.location.content,
            }
        }
    }



    onFormSubmit = ev => {
        let authtoken = this.props.authtoken
        if (authtoken === '') {
            authtoken = sessionStorage.getItem('authtoken')
        }
        const AUTH_HEADERS = {
            'Content-Type': 'application/json',
            'Authorization': 'Kinvey ' + authtoken
        }

        ev.preventDefault()
        let messageId = this.props.match.params.id
        fetch(BASE_URL + 'appdata/' + APP_KEY + '/messages/' + messageId, {
            method: 'DELETE',
            headers: AUTH_HEADERS,
            body: JSON.stringify(this.state.message)
        }).then(res => res.json()
            .then(data => {
               //console.log(this.state)
               observer.trigger(observer.events.notification, { type: 'success', message: 'Message Deleted Successfully' })
               this.props.history.push("/")
            }))
    }

 

    render() {
        return (
            <form id='mainForm' onSubmit={this.onFormSubmit}>
                <textarea disabled name="content" placeholder="message..." value={this.state.message.content}></textarea>
                <button type="submit" className="button">DELETE</button>
            </form>
        )
    }
}