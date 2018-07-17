import React, { Component, Fragment } from 'react'
import { Route } from 'react-router-dom'
import Register from './Register'
import Login from './Login'
import Logout from './Logout'
import Profile from './Profile'
import Terms from './Terms'
import Edit from '../Chatbox/Edit'
import Users from './Users'
import Delete from '../Chatbox/Delete'
import EditUser from './Edit'
import DeleteUser from './Delete'
import AdminUser from './MakeAdmin'
import UnAdminUser from './UnAdmin'
import TheBlackHole from '../Chatbox/TheBlackHole'


export default class User extends Component {
    constructor(props) {
        super(props)
        this.state = {
            username: '',
            authtoken: '',
            userId: '',
            email: ''
        }
    }

    getUserInfo = (name, token, id, email) => {
        this.setState({
            username: name,
            authtoken: token,
            userId: id,
            email
        })
    }

     getInfo = props => {
        return (
            <Login getUserInfo={this.getUserInfo} {...props} />
        )
      }

      sendToProfile = props => {
        return (
          <Profile authtoken={this.state.authtoken} userId={this.state.userId} email={this.state.email} {...props}/>
        )
      }

      sendToLogout = props => {
        return (
          <Logout authtoken={this.state.authtoken}{...props}/>
        )
      }

      sendToUsers = props => {
        return (
          <Users authtoken={this.state.authtoken}{...props}/>
        )
      }

      sendToEdit = props => {
        return (
          <Edit authtoken={this.state.authtoken}{...props}/>
        )
      }

      sendToDelete = props => {
        return (
          <Delete authtoken={this.state.authtoken}{...props}/>
        )
      }

      sendToEditUser = props => {
        return (
          <EditUser authtoken={this.state.authtoken}{...props}/>
        )
      }

      sendToDeleteUser = props => {
        return (
          <DeleteUser authtoken={this.state.authtoken}{...props}/>
        )
      }

     



    render() {
        return (
            <Fragment >
                <Route path='/register' exact component={Register} />
                <Route path='/login' exact render={this.getInfo}/>
                <Route path='/logout' exact render={this.sendToLogout} />
                <Route path='/profile' exact render={this.sendToProfile} />
                <Route path='/tos' exact component={Terms} />
                <Route path='/edit/:id' exact render={this.sendToEdit}/>
                <Route path='/delete/:id' exact render={this.sendToDelete} />
                <Route path='/users' exact render={this.sendToUsers} />
                <Route path='/user/edit/:id' exact render={this.sendToEditUser} />
                <Route path='/user/delete/:id' exact render={this.sendToDeleteUser} />
                <Route path='/user/admin/:id' exact component={AdminUser} />
                <Route path='/user/unadmin/:id' exact component={UnAdminUser} />
                <Route path='/blackhole' exact component={TheBlackHole} />
            </Fragment>
        )
    }
}