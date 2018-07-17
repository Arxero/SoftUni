import React, { Component } from 'react'
import './styles/form.css'

export default class LoginForm extends Component {
    constructor(props) {
        super(props)

        this.state = {
            user: {

            }
        }
    }

    onInputChanged = event => {
        let user = this.state.user
        let inputName = event.target.name
        let inputValue = event.target.value
        user[inputName] = inputValue

        this.setState({
            user: Object.assign(this.state.user, user)
        })

    }

    onFormSubmit = event => {
        event.preventDefault()

        fetch('http://localhost:5000/auth/login', {
            method: 'POST',
            body: JSON.stringify(this.state.user),
            headers: {
                'Content-Type': 'application/json'
            }
        }).then(data => data.json()
        ).then(res => {
            if (res.success && res.token) {
                localStorage.setItem('token', JSON.stringify(res.token))
                this.props.setloggedIn()
            }
        }).catch(err => console.log(err))

        //console.log(this.state.user)
    }

    render() {
        return (
            <form className="modal-content" onSubmit={this.onFormSubmit}>
                <div className="container">
                    <h1>Login</h1>
                    <hr />
                    <label><b>Email</b></label>
                    <input type="text" placeholder="Enter Email" name="email" required onChange={this.onInputChanged} />

                    <label><b>Password</b></label>
                    <input type="password" placeholder="Enter Password" name="password" required onChange={this.onInputChanged} />

                    <div className="clearfix">
                        <button type="button" className="cancelbtn">Cancel</button>
                        <button type="submit" className="signupbtn">Login</button>
                    </div>
                </div>
            </form>
        )
    }
}

