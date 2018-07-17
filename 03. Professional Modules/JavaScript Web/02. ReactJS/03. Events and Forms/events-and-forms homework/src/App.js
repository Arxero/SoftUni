import React, { Component } from 'react'
import './App.css'
import SingUpForm from './components/signup'
import LoginForm from './components/login'
import LoggedInScreen from './components/logged/loggedInScreen'

class App extends Component {
    constructor(props) {
        super(props)
        let route = 'register'
        if (localStorage.getItem('token')) {
            route = 'loggedIn'
        }
       
        this.state = {
            route: route
        }
    }

    showComponent = () => {
        if (this.state.route === 'register' && !localStorage.getItem('token')) {
            return <SingUpForm setloggedIn={() => this.setState({ route: 'registered'})}/>
        } else if (this.state.route === 'login'  && !localStorage.getItem('token')) {
            return <LoginForm setloggedIn={() => this.setState({ route: 'loggedIn'})}/>
        } else if (this.state.route === 'loggedIn' && localStorage.getItem('token')) {
            return <LoggedInScreen />
        }  else if (this.state.route === 'registered') {
            return <h1>You have successfully registered!</h1>
        }
      
    }

    switchForms = () => {
        if (this.state.route === 'login') {
            this.setState({ route: 'register'})
        } else if (this.state.route === 'register') {
            this.setState({route: 'login'})
        } else if (this.state.route === 'loggedIn') {
            this.setState({ route: 'login'})
            localStorage.clear()
        } else {
            this.setState({ route: 'login'})
        }
    }

    showButtonText = () => {
        if (this.state.route === 'register' || this.state.route === 'registered') {
            return 'Login'
        } else if (this.state.route === 'login') {
            return 'Register'
        } else if (this.state.route === 'loggedIn') {
            return 'Logout'
        }
    }

    // setloggedIn = () => {
    //     this.setState({ route: 'loggedIn'})
    // }

  render() {
    return (
      <div className="App">
        {this.showComponent()}
        <button onClick={this.switchForms}>{this.showButtonText()}</button>
      </div>
    );
  }
}

export default App
