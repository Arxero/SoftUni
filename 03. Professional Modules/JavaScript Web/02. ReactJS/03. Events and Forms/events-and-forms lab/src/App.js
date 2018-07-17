import React, { Component } from 'react';
import './App.css';
// import ButtonWithClick from './button-click';
// import RegisterForm from './registerForm';
import Container from './container';

class App extends Component {
  render() {
    return (
      <div className="App">
       <Container>
           <div>Hello</div>
           <h2>HEllo 2!</h2>
       </Container>
      </div>
    );
  }
}

export default App;
