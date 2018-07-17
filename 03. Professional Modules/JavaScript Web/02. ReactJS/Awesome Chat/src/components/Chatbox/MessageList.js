import React, { Component } from 'react'
import Message from './Message'


const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"
const APP_SECRET = "81a1e194d5734b3e95aa8f063dff7306"



export default class MessageList extends Component {
    constructor(props) {
        super(props)
        this.state = {
            messages: [],
        }

    }

    getMessages = guestAuthtoken => {
        //console.log(guestAuthtoken)
        fetch(BASE_URL + 'appdata/' + APP_KEY + '/messages', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': "Kinvey " + guestAuthtoken
            },
        }).then(res => res.json()
            .then(data => {
                //console.log(this.state)
                if (!data.error) {
                    this.setState({
                        messages: data
                    })
                }
            }))
    }

    componentDidMount = () => {
        //logging in guest user or order to retrieve the messages
        fetch(BASE_URL + 'user/' + APP_KEY + '/login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)
            },
            body: JSON.stringify({ username: 'guest', password: 'guest' })
        }).then(res => res.json().then(data => {
            sessionStorage.setItem('authtokenGuest', data._kmd.authtoken)
            this.getMessages(data._kmd.authtoken)
        }))
    }

    render() {
        return (
            <div>
                {this.state.messages.map((message, index) => <Message key={message._id} index={index}{...message} id={message._id} />)}
            </div>
        )
    }
}

