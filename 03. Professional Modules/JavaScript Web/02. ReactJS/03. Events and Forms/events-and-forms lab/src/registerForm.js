import React, { Component } from 'react'

export default class RegisterForm extends Component {
    constructor(props) {
        super(props)

        this.state = {
            user: {
                username: '',
                password: ''
            },
            error: ''
        }
    }

    onInputChanged = event => {
        let user = this.state.user
        let username = event.target.name
        let password = event.target.value
        user[username] = password

        this.setState({
            user
        })
    }

    onFormSubmit = event => {
        event.preventDefault()

        if (this.state.user.password.length < 6) {
            this.setState({
                error: 'Password must be more than 6 symbols.'
            })
            return
        } else {
            this.setState({
                error: ''
            })
        }
    }
    

    render() {
        return (
            <form onSubmit={this.onFormSubmit}>
                <div>{this.state.error}</div>
                Username:
               <input type="text" name='username' onChange={this.onInputChanged} value={this.state.user.username} />
                <br />
                Password:
                <input type="password" name='password' onChange={this.onInputChanged} value={this.state.user.password} />
                <br />
                <input type="submit" />
            </form>
        )
    }
}