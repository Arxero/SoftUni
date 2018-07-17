import React, { Component } from 'react'
import '../styles/header.css'
import '../styles/menu.css'
import '../styles/site.css'
import { Link } from 'react-router-dom'


export default class Menu extends Component {
    render() {
        return (
            <div id="menu">
                <div className="title">Navigation</div>
                <Link to="/" className="nav">Home</Link>
                <Link to="/catalog" className="nav">Catalog</Link>
                <Link to="/" className="nav">Submit Link</Link>
                <Link to="/" className="nav">My Posts</Link>
            </div>
        )
    }
}

