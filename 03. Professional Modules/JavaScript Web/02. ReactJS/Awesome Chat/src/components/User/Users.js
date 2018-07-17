import React, { Component } from 'react'
import '../../styles/users.css'
import '../../styles/home.css'
import TableRow from './TableRow';

const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJXp0ATGQ"

export default class Users extends Component {
    constructor(props) {
        super(props)
        this.state = {
            users: [],
        }

    }

    getUsers = () => {
        let authtoken = this.props.authtoken
        if (authtoken === '') {
            authtoken = sessionStorage.getItem('authtoken')
        }
        const AUTH_HEADERS = {
            'Content-Type': 'application/json',
            'Authorization': 'Kinvey ' + authtoken
        }


        fetch(BASE_URL + 'user/' + APP_KEY, {
            method: 'GET',
            headers: AUTH_HEADERS,
        }).then(res => res.json()
            .then(data => {
                //console.log(data)
                if (!data.error) {
                    this.setState({
                        users: data
                    })
                }
            }))
    }

    componentDidMount = () => this.getUsers()

    render() {
        return (
            <div id='allUsersTitle'>
                <h1 >All Registered Users</h1>

                <table id="users">
                    <tbody>
                        <tr>
                            <th>Username</th>
                            <th>Contact</th>
                            <th>Avatar</th>
                            <th>Joined</th>
                            <th>Status</th>
                            <th>Action</th>
                        </tr>
                        {this.state.users.filter(x => x.username !== 'guest' && x.username !== sessionStorage.getItem('username')).map(user => <TableRow key={user._id} {...user} />)}
                    </tbody>
                </table>
            </div>
        )
    }
}