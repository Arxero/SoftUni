import React, { Component } from 'react'
import '../../styles/site.css'
import observer from '../observer'
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJRtT9_fX"
const APP_SECRET = "ccd1512768df42428f48c92a452fdb3b"
const AUTH_HEADERS = {
    'Content-Type': 'application/json',
    'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)
}


export default class Login extends Component {
    constructor(props) {
        super(props)
        this.state = {
            user: {
                username: '',
                password: ''
            },
        }
    }

    onInputChange = ev => {
        let user = this.state.user
        let inputName = ev.target.name
        let inputValue = ev.target.value
        user[inputName] = inputValue

        this.setState({
            user
        })
    }


    onFormSubmit = ev => {
        ev.preventDefault()

        fetch(BASE_URL + 'user/' + APP_KEY + '/login', {
            method: 'POST',
            body: JSON.stringify(this.state.user),
            headers: AUTH_HEADERS,
        })
            .then(res => res.json())
            .catch(err => console.log('Something is wrong with the request'))
            .then(data => {
                if (data.username) { // correct credentials
                    observer.trigger(observer.events.loginUser, data.username)
                    observer.trigger(observer.events.notification, { type: 'success', message: 'Login Successful' })
                    sessionStorage.setItem('username', data.username)
                    sessionStorage.setItem('authtoken', data._kmd.authtoken)
                    sessionStorage.setItem('id', data._id)
                    this.props.history.push('/catalog')
                } else { //wrong credentials
                    observer.trigger(observer.events.notification,
                        { type: 'error', message: data.description })
                        this.setState({
                            user: {
                                username: '',
                                password: ''
                            }
                        })
                }
            })
    }

    render = () => {
        return (
            <form id="loginForm" onSubmit={this.onFormSubmit}>
                <h2>Sign In</h2>
                <label>Username:</label>
                <input name="username" type="text" onChange={this.onInputChange} value={this.state.user.username} />
                <label>Password:</label>
                <input name="password" type="password" onChange={this.onInputChange} value={this.state.user.password} />
                <input id="btnLogin" value="Sign In" type="submit" />
            </form>
        )
    }
}

