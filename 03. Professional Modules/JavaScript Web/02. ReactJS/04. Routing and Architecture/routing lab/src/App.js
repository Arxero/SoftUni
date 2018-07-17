import React, { Component } from 'react'
import './App.css'
import Navigaton from './components/navigaton'
import Footer from './components/footer'
import AppRouter from './AppRouter';

class App extends Component {
    render() {
        return (
            <div>
                <Navigaton />
                <AppRouter />
                <Footer />
            </div>
        )
    }
}

export default App
