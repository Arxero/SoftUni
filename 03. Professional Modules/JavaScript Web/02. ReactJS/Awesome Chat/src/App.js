import React, { Component } from 'react'
import './App.css'
import './styles/home.css'
import { Route } from 'react-router-dom'
import Navigation from './components/Menu';
import Home from './components/Home';
import User from './components/User/Main';
import Notification from './components/User/Notification';

class App extends Component {
    render() {
        return (
            <div>
                <Navigation />
                <div className='page-body'>
                    <div className='page-content'>
                        <Route path='/' exact component={Home} />
                        <Notification />
                        <User />
                    </div>
                </div>
            </div>
        )
    }
}

export default App
