import React, { Component } from 'react'
import '../../styles/form.css'
import { Link } from 'react-router-dom'
import observer from '../../observer'
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"
const APP_SECRET = "81a1e194d5734b3e95aa8f063dff7306"
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
                password: '',
            }
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
            headers: AUTH_HEADERS,
            body: JSON.stringify(this.state.user)
        }).then(res => res.json())
            .catch(err => console.log('Something is wrong with the request'))
            .then(data => {
                if (data.username) { // correct credentials
                    //console.log(data)
                    observer.trigger(observer.events.loginUser, data.username)
                    observer.trigger(observer.events.userToken, data._kmd.authtoken)
                    observer.trigger(observer.events.notification, { type: 'success', message: 'Login Successful' })
                    sessionStorage.setItem('username', data.username)
                    sessionStorage.setItem('authtoken', data._kmd.authtoken)
                    sessionStorage.setItem('image', data.image)
                    sessionStorage.setItem('id', data._id)
                    sessionStorage.setItem('status', data.status)
                    sessionStorage.setItem('email', data.email)
                    if (data._kmd.roles && data._kmd.roles.length > 0) {
                        sessionStorage.setItem('role', data._kmd.roles[0].roleId)
                    }
                    this.props.history.push("/")
                    this.props.getUserInfo(data.username, data._kmd.authtoken, data._id, data.email)
                } else { //errror hadnling of some kind
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

    render() {
        return (
            <form className="modal-content-login" onSubmit={this.onFormSubmit}>
                <div className="container">
                    <h1>Login</h1>

                    <label><b>Username</b></label>
                    <input type="text" placeholder="Enter Username" name="username" required onChange={this.onInputChange} value={this.state.user.username} />

                    <label><b>Password</b></label>
                    <input type="password" placeholder="Enter Password" name="password" required onChange={this.onInputChange} value={this.state.user.password} />

                    <p>Don't have an account? <Link to="/register" style={{ color: 'dodgerblue' }}>Sign Up</Link>.</p>

                    <div className="clearfix">
                        <button type="button" className="cancelbtn" onClick={() => this.props.history.push("/")}>Cancel</button>
                        <button type="submit" className="signupbtn">Login</button>
                    </div>
                </div>
            </form>
        )
    }

}