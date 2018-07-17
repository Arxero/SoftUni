import React, { Component } from 'react'
import { Link } from 'react-router-dom'
import '../styles/menu.css'
import observer from '../observer'

export default class Navigation extends Component {
    constructor(props) {
        super(props)
        this.state = {
            clicked: false
        }

        observer.subscribe(observer.events.loginUser, this.userLoggedIn)
    }

    userLoggedIn = username => this.setState({ username })

    onMenuClick = () => {
        this.setState({
            clicked: !this.state.clicked
        })
    }

   

    render() {
        let loggedInSectionUsers = ''
        let loggedInSection = 
            <div>
                <li id='login'><Link to="/login"><i className="material-icons">power_settings_new</i>Login</Link></li>
                <li id='register'><Link to="/register"><i className="material-icons">assignment</i>Register</Link></li>
            </div>

            if (this.state.username || sessionStorage.getItem('username')) {
                //console.log(this.state.authtoken)
                loggedInSectionUsers = <li><Link to="/users"><i className="material-icons">supervisor_account</i>Users</Link></li>
                loggedInSection = 
                <div>
                    <li id='logout'><Link to="/logout"><i className="material-icons">power_settings_new</i>Logout</Link></li>
                    <li id='username'><Link to="/profile"><i className="material-icons">account_circle</i>{this.state.username || sessionStorage.getItem('username')}</Link></li>
                </div>
            }
        return (
            <div>
                <h1>Awesome Chat</h1>
                <nav className="nav">
                    <ul>
                        <li ref='item' onLoad={() => this.refs.item.focus()}><Link to="/"><i className="material-icons">home</i>Home</Link></li>
                        {loggedInSectionUsers}
                        <li><Link to="/tos">TOS</Link></li>
                        <li className="drop" onClick={this.onMenuClick}><Link to="#"><i className="material-icons">link</i>Links</Link>
                            <ul className="dropdown">
                                {this.state.clicked &&
                                    <div>
                                        <li><a target='_blank' rel="noopener noreferrer" href="https://github.com/Arxero/Awesome-Chat">GitHub</a></li>
                                        <li><a target='_blank' rel="noopener noreferrer" href="http://awesomecs.syntrwave.com/">Our Forum</a></li>
                                    </div>}
                            </ul>
                        </li>
                        {loggedInSection}
                    </ul>
                </nav>
            </div>
        )
    }
}