import React, { Component } from 'react'
import '../styles/header.css'
import observer from './observer'
import { Link } from 'react-router-dom'


export default class Header extends Component {
    constructor(props) {
        super(props)
        this.state = {
            username: ''
        }

        observer.subscribe(observer.events.loginUser, this.userLoggedIn)
    }

    userLoggedIn = username => this.setState({ username })



    render = () => {
        let loggedInSection = null
        if (this.state.username || sessionStorage.getItem('username')) {
            loggedInSection = <div id="profile">
                <span>{this.state.username || sessionStorage.getItem('username')}</span>|
                <Link to="/logout">logout</Link>
            </div>
        }

        return (
            <header>
                <span className="logo">☃</span><span className="header">SeenIt</span>
                {loggedInSection}
            </header>
        )
    }
}

