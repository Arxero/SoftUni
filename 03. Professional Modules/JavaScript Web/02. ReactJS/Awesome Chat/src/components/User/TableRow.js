import React, { Component } from 'react'
import { Link } from 'react-router-dom'
const ROLE = '3997924e-436c-495d-a181-d6af1ba20eb4'

export default class TableRow extends Component {

    render() {
        let editIcon = ''
        let deleteIcon = ''
        let makeAdminIcon = ''
        let unAdminIcon = ''
        if (sessionStorage.getItem('role') === ROLE) {
            let propsToSendEdit = {
                pathname: `/user/edit/${this.props._id}`,
                image: this.props.image,
                status: this.props.status,
                username: this.props.username,
                email: this.props.email
            }
            let propsToSendDelete = {
                pathname: `/user/delete/${this.props._id}`,
                image: this.props.image,
                status: this.props.status,
                username: this.props.username,
                email: this.props.email
            }
            let propsToSendMakeAdmin  = {
                pathname: `/user/admin/${this.props._id}`,
                image: this.props.image,
                status: this.props.status,
                username: this.props.username,
                email: this.props.email
            }

            let propsToSendUnAdmin  = {
                pathname: `/user/unadmin/${this.props._id}`,
                image: this.props.image,
                status: this.props.status,
                username: this.props.username,
                email: this.props.email
            }
            //console.log(this.props)
            editIcon = <Link to={propsToSendEdit}><i id='editUserIcon' className="material-icons">create</i></Link>
            deleteIcon = <Link to={propsToSendDelete}><i id='deleteUserIcon' className="material-icons">delete</i></Link>
            makeAdminIcon = <Link to={propsToSendMakeAdmin}><i id='deleteUserIcon' className="material-icons">keyboard_arrow_up</i></Link>
            unAdminIcon = <Link to={propsToSendUnAdmin}><i id='deleteUserIcon' className="material-icons">keyboard_arrow_down</i></Link>
        }

        return (
            <tr>
                <td>{this.props.username}</td>
                <td>{this.props.email}</td>
                <td>
                    <img src={this.props.image ? this.props.image : 'https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/f8/f8de58eb18a0cad87270ef1d1250c574498577fc_full.jpg'} alt="noimage" />
                </td>
                <td>{new Date(this.props._kmd.ect).toLocaleDateString('en-GB')}</td>
                <td>{this.props.status}</td>
                <td>
                    <i className="material-icons" onClick={() => window.open(`mailto:${this.props.email}`)}>mail</i>
                    {editIcon}
                    {deleteIcon}
                    {makeAdminIcon}
                    {unAdminIcon}
                </td>
            </tr>
        )
    }
}
