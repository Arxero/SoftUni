import React, { Component } from 'react'
import { Link } from 'react-router-dom'
import '../../styles/form.css'
import observer from '../../observer';
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"
const APP_SECRET = "81a1e194d5734b3e95aa8f063dff7306"
const AUTH_HEADERS = {
    'Content-Type': 'application/json',
    'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)
}


export default class Register extends Component {
    constructor(props) {
        super(props)
        this.state = {
            user: {
                username: '',
                password: '',
                email: '',
                image: 'https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/f8/f8de58eb18a0cad87270ef1d1250c574498577fc_full.jpg',
                status: 'Online'
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

        if (RegExp('^[a-zA-Z]{3,}$').test(this.state.user.username)) {
            if (RegExp('^[a-zA-Z0-9]{3,}$').test(this.state.user.password)) {
                if (RegExp('^[^@]+@[^@]+[^@]+$').test(this.state.user.email)) {

                    fetch(BASE_URL + 'user/' + APP_KEY + '/', {
                        method: 'POST',
                        headers: AUTH_HEADERS,
                        body: JSON.stringify(this.state.user)
                    }).then(res => res.json())
                        .catch(err => console.log('Something is wrong with the request'))
                        .then(data => {
                            if (data.username) { // correct credentials
                                observer.trigger(observer.events.loginUser, data.username)
                                observer.trigger(observer.events.notification, { type: 'success', message: 'Register Successful' })
                                sessionStorage.setItem('username', data.username)
                                sessionStorage.setItem('authtoken', data._kmd.authtoken)
                                sessionStorage.setItem('image', data.image)
                                sessionStorage.setItem('id', data._id)
                                sessionStorage.setItem('status', data.status)
                                sessionStorage.setItem('email', data.email)
                                this.props.history.push("/")
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

                } else {
                    observer.trigger(observer.events.notification,
                        { type: 'error', message: 'Invalid email address' })
                }
            } else {
                observer.trigger(observer.events.notification,
                    { type: 'error', message: 'A password should be at least 3 characters long and should contain only english alphabet letters and digits' })
            }
        } else {
            observer.trigger(observer.events.notification,
                { type: 'error', message: 'A username should be at least 3 characters long and should contain only english alphabet letters' })
        }
    }

    render() {
        return (
            <form className="modal-content" onSubmit={this.onFormSubmit}>
                <div className="container">
                    <h1>Sign Up</h1>
                    <p>Please fill in this form to create an account.</p>
                    <hr />

                    <label><b>Username</b></label>
                    <input type="text" placeholder="Enter Username" name="username" required onChange={this.onInputChange} value={this.state.user.username} />

                    <label><b>Email</b></label>
                    <input type="text" placeholder="Enter Email" name="email" required onChange={this.onInputChange} value={this.state.user.email} />

                    <label><b>Profile Image</b></label>
                    <input type="text" placeholder="Enter Image URL" name="image" onChange={this.onInputChange} value={this.state.user.image} />

                    <label><b>Password</b></label>
                    <input type="password" placeholder="Enter Password" name="password" required onChange={this.onInputChange} value={this.state.user.password} />

                    <p>By creating an account you agree to our <Link to="/tos" style={{ color: 'dodgerblue' }}>Terms & Privacy</Link>.</p>

                    <p>Already have an account? <Link to="/login" style={{ color: 'dodgerblue' }}>Sign In</Link>.</p>

                    <div className="clearfix">
                        <button type="button" className="cancelbtn" onClick={() => this.props.history.push("/")}>Cancel</button>
                        <button type="submit" className="signupbtn">Sign Up</button>
                    </div>
                </div>
            </form>
        )
    }

}