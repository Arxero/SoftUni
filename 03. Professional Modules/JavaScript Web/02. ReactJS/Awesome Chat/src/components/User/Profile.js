import React, { Component } from 'react'
import observer from '../../observer';
const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"


export default class Profile extends Component {
    constructor(props) {
        super(props)
        this.state = {
            user: {
                image: 'https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/f8/f8de58eb18a0cad87270ef1d1250c574498577fc_full.jpg',
                email: sessionStorage.getItem('email'),
                status: sessionStorage.getItem('status')
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
        let authtoken = this.props.authtoken
        if (authtoken === '') {
            authtoken = sessionStorage.getItem('authtoken')
        }

        const AUTH_HEADERS = {
            'Content-Type': 'application/json',
            'Authorization': 'Kinvey ' + authtoken
        }

        fetch(BASE_URL + 'user/' + APP_KEY + '/' + sessionStorage.getItem('id'), {
            method: 'PUT',
            headers: AUTH_HEADERS,
            body: JSON.stringify(this.state.user)
        }).then(res => res.json())
            .then(data => {
                observer.trigger(observer.events.notification, { type: 'success', message: 'Profile Edited Successfully' })
                sessionStorage.setItem('image', data.image)
                sessionStorage.setItem('status', data.status)
                sessionStorage.setItem('email', data.email)
                this.props.history.push("/")
            })
    }


    render() {
        return (
            <form className="modal-content-profile" onSubmit={this.onFormSubmit}>
                <div className="container">
                    <h1>Edit Profile</h1>

                    <label><b>Status</b></label>
                    <br/>
                    <select value={this.state.user.status} onChange={this.onInputChange} name="status">
                        <option value="Online">Online</option>
                        <option value="Away">Away</option>
                        <option value="Busy">Busy</option>
                        <option value="Looking To Play" name='lookingToPlay'>Looking to Play</option>
                    </select>
                    <br/>
                    <label><b>Email</b></label>
                    <input type="text" placeholder="Enter email" name="email" onChange={this.onInputChange} value={this.state.user.email} />

                    <label><b>Avatar</b></label>
                    <input type="text" placeholder="Enter Image URL" name="image" onChange={this.onInputChange} value={this.state.user.image} />
                    
                    <label id='oldImage'>Old</label>
                    <img src={sessionStorage.getItem('image')} alt='noimage' />
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