import React, { Component } from 'react'
import observer from '../../observer'
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"


export default class Logout extends Component {
    
    logout = () => {
        let authtoken = this.props.authtoken
        if (authtoken === '') {
            authtoken = sessionStorage.getItem('authtoken')
        }
        const AUTH_HEADERS = {
            'Content-Type': 'application/json',
            'Authorization': 'Kinvey ' + authtoken
        }

        fetch(BASE_URL + 'user/' + APP_KEY + '/_logout', {
            method: 'POST',
            headers: AUTH_HEADERS,
        }).then(res => {
            //console.log(AUTH_HEADERS)
            sessionStorage.clear()
            observer.trigger(observer.events.loginUser)
            observer.trigger(observer.events.notification, { type: 'success', message: 'Logout Successful' })
            this.props.history.push("/login")
            this.props.history.push("/")
        })
    }

    render = () => {
        return (
            <div>
                {this.logout()}
            </div>

        )
    }
}
