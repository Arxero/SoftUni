import React, { Component } from 'react'
import observer from '../../observer';
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"

export default class EditUser extends Component {
    constructor(props) {
        super(props)
        this.state = {
            user: {
                image: 'https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/f8/f8de58eb18a0cad87270ef1d1250c574498577fc_full.jpg',
                status: this.props.location.status,
                username: this.props.location.username,
                email: this.props.location.email
            }
        }
    }

    getOldImage = () => this.props.location.image

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
        let authtoken = this.props.authtoken
        let userId = this.props.match.params.id
        if (authtoken === '') {
            authtoken = sessionStorage.getItem('authtoken')
        }

        const AUTH_HEADERS = {
            'Content-Type': 'application/json',
            'Authorization': 'Kinvey ' + authtoken
        }

        if (RegExp('^[a-zA-Z]{3,}$').test(this.state.user.username)) {
            if (RegExp('^[a-zA-Z0-9]{3,}$').test(this.state.user.password)) {
                if (RegExp('^[^@]+@[^@]+[^@]+$').test(this.state.user.email)) {
                    
                    fetch(BASE_URL + 'user/' + APP_KEY + '/' + userId, {
                        method: 'PUT',
                        headers: AUTH_HEADERS,
                        body: JSON.stringify(this.state.user)
                    }).then(res => res.json())
                        .then(data => {
                            //console.log(data)
                            observer.trigger(observer.events.notification, { type: 'success', message: 'User Edited Successfully' })
                            this.props.history.push("/users")
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
            <form className="modal-content-profile" onSubmit={this.onFormSubmit}>
                <div className="container">
                    <h1>Edit {this.state.user.username}'s Profile</h1>

                    <label><b>Username</b></label>
                    <input type="text" placeholder="Enter Username" name="username" onChange={this.onInputChange} value={this.state.user.username} />

                    <label><b>Status</b></label>
                    <br />
                    <select value={this.state.user.status} onChange={this.onInputChange} name="status">
                        <option value="Online">Online</option>
                        <option value="Away">Away</option>
                        <option value="Busy">Busy</option>
                        <option value="Looking To Play" name='lookingToPlay'>Looking to Play</option>
                    </select>
                    <br />
                    <label><b>Email</b></label>
                    <input type="text" placeholder="Enter email" name="email" onChange={this.onInputChange} value={this.state.user.email} />

                    <label><b>Avatar</b></label>
                    <input type="text" placeholder="Enter Image URL" name="image" onChange={this.onInputChange} value={this.state.user.image} />

                    <label id='oldImage'>Old</label>
                    <img src={this.getOldImage()} alt='noimage' />
                    <label id='newImage'>New</label>
                    <img src={this.state.user.image} alt='noimage' />


                    <div className="clearfix">
                        <button type="button" className="cancelbtn" onClick={() => this.props.history.push("/")}>Cancel</button>
                        <button type="submit" className="signupbtn">Submit</button>
                    </div>
                </div>
            </form>
        )
    }
}