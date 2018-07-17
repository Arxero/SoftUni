import React, { Component } from 'react'
import './styles/form.css'

export default class SingUpForm extends Component {
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

        fetch('http://localhost:5000/auth/signup', {
            method: 'POST',
            body: JSON.stringify(this.state.user),
            headers: {
                'Content-Type': 'application/json'
            }
        }).then(data => data.json()
        ).then(res => console.log(res))
        this.props.setloggedIn()
        //console.log(this.state.user)
    }

    render() {
        return (
            <form className="modal-content" onSubmit={this.onFormSubmit}>
                <div className="container">
                    <h1>Sign Up</h1>
                    <p>Please fill in this form to create an account.</p>
                    <hr />
                    <label><b>Email</b></label>
                    <input type="text" placeholder="Enter Email" name="email" required onChange={this.onInputChanged} />

                    <label><b>Username</b></label>
                    <input type="text" placeholder="Enter Username" name="name" required onChange={this.onInputChanged} />

                    <label><b>Password</b></label>
                    <input type="password" placeholder="Enter Password" name="password" required onChange={this.onInputChanged} />
                    <p>By creating an account you agree to our Terms & Privacy.</p>

                    <div className="clearfix">
                        <button type="button" className="cancelbtn">Cancel</button>
                        <button type="submit" className="signupbtn">Sign Up</button>
                    </div>
                </div>
            </form>
        )
    }
}

