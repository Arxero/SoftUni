import React, { Component } from 'react'
import { Redirect } from 'react-router-dom'
import Header from '../Header';
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJRtT9_fX"
//const APP_SECRET = "ccd1512768df42428f48c92a452fdb3b"
const AUTH_HEADERS = {
    'Content-Type': 'application/json',
    'Authorization': 'Kinvey ' + sessionStorage.getItem('authtoken')
}


export default class Logout extends Component {
    logout = () => {
        fetch(BASE_URL + 'user/' + APP_KEY + '/_logout', {
            method: 'POST',
            headers: AUTH_HEADERS,
        }).then(res => sessionStorage.clear())
            .catch(err => console.log(err))
    }


    render = () => {
        return (
            <div>
                {this.logout()}
                <Header />
                <Redirect to='/' />
            </div>
            
        )
    }
}
