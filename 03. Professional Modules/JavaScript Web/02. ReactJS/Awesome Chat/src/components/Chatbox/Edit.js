import React, { Component } from 'react'
import observer from '../../observer';
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"


export default class Edit extends Component {
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


    onInputChange = ev => {
        let message = this.state.message
        let inputName = ev.target.name
        let inputValue = ev.target.value
        message[inputName] = inputValue

        this.setState({
            message
        })
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
            method: 'PUT',
            headers: AUTH_HEADERS,
            body: JSON.stringify(this.state.message)
        }).then(res => res.json()
            .then(data => {
                observer.trigger(observer.events.notification, { type: 'success', message: 'Message Edited Successfully' })
               //console.log(this.state)
               this.props.history.push("/")
            }))
    }

 

    render() {
        return (
            <form id='mainForm' onSubmit={this.onFormSubmit}>
                <textarea name="content" placeholder="message..." required onChange={this.onInputChange} value={this.state.message.content}></textarea>
                <button type="submit" className="button">SAVE</button>
            </form>
        )
    }
}