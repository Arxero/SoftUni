import React, { Component } from 'react'
import '../../styles/chatbox.css'
import { Redirect } from 'react-router-dom'

const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"

export default class Textarea extends Component {
    constructor(props) {
        super(props)

        this.state = {
            message: {
                author: sessionStorage.getItem('username'),
                image: sessionStorage.getItem('image'),
                content: '',
            },
            redirect: false
        }

    }
    
      renderRedirect = () => {
        if (this.state.redirect) {
          return <Redirect to='/blackhole' />
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
        this.setState({
            redirect: true
          })


        ev.preventDefault()
        // console.log(sessionStorage.getItem('authtoken'))
        const AUTH_HEADERS = {
            'Content-Type': 'application/json',
            'Authorization': "Kinvey " + sessionStorage.getItem('authtoken')
        }

        fetch(BASE_URL + 'appdata/' + APP_KEY + '/messages', {
            method: 'POST',
            headers: AUTH_HEADERS,
            body: JSON.stringify(this.state.message)
        }).then(res => res.json())
            .then(data => {
               //console.log(data)
            })
    }

    render() {
        let send = ''
        if (sessionStorage.getItem('username')) {
            send =  <button type="submit" className="button" onClick={this.setRedirect}>SEND</button>
        }
        return (
            <form id='mainForm' onSubmit={this.onFormSubmit}>
                <textarea name="content" placeholder="message..." required onChange={this.onInputChange}></textarea>
                {this.renderRedirect()}
                {send}
            </form>
        )
    }
}
