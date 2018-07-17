import React, { Component } from 'react'
import { Link } from 'react-router-dom'
import '../styles/home.css'
import Chatbox from './Chatbox/Main';
import Info from './Chatbox/Info';

export default class Home extends Component {
     

    render() {
        let startButton = <Link to='/login'><h2 className='button'>Start the conversation Now!</h2></Link>
        if (sessionStorage.getItem('username')) {
            startButton = ''
        }
        return (
            <div>
                <Info />
                <Chatbox />
                {startButton}
            </div>
        )
    }
}