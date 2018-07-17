import React, { Component } from 'react'
import { Route } from 'react-router-dom'
import './App.css'
import './styles/site.css'
import Header from './components/Header'
import Home from './components/Home'
import Logout from './components/user/Logout'
import Notification from './components/Notificaton';


class App extends Component {
    render() {
        return (
            <div id='container'>
                <Header />
                <Home />
                <Notification />
                <Route path='/logout' exact component ={Logout} />
            </div>
        )
    }
}

export default App
