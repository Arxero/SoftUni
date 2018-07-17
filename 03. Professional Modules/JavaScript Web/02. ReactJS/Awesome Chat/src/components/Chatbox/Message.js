import React, { Component } from 'react'
import { Link } from 'react-router-dom'
import '../../styles/chatbox.css'
const ROLE = '3997924e-436c-495d-a181-d6af1ba20eb4'
//import Edit from './Edit';


export default class Message extends Component {
    // constructor(props) {
    //     super(props)
    // }

    


    render() {
        let editIcon = ''
        let deleteIcon = ''
        if (sessionStorage.getItem('username') === this.props.author || sessionStorage.getItem('role') === ROLE) {
            let propsToSend = {
                pathname: `/edit/${this.props.id}`,
                content: this.props.content,
                author: this.props.author,
                image: this.props.image
            }
            //console.log(this.props)
            editIcon = <Link to={propsToSend}><span id='editIcon'><i className="material-icons">create</i></span></Link>
        }

        if (sessionStorage.getItem('role') === ROLE) {
            let propsToSend = {
                pathname: `/delete/${this.props.id}`,
                content: this.props.content,
                author: this.props.author,
                image: this.props.image
            }
            //console.log(this.props)
            deleteIcon = <Link to={propsToSend}><span id='editIcon'><i className="material-icons">delete</i></span></Link>
        }

        return (
            <div id='userMessage'>
                <img src={this.props.image} alt="nope" />
                <p id='userNameColor'>{this.props.author}</p>
                <p id='userMessageText'>{this.props.content}</p>
                <span id='messageDate'>{calcTime(this.props._kmd.ect)} ago</span>
                {deleteIcon}
                {editIcon}
            </div>
        )
    }
}


function calcTime(dateIsoFormat) {
    let diff = new Date() - (new Date(dateIsoFormat));
    diff = Math.floor(diff / 60000);
    if (diff < 1) return 'less than a minute';
    if (diff < 60) return diff + ' minute' + pluralize(diff);
    diff = Math.floor(diff / 60);
    if (diff < 24) return diff + ' hour' + pluralize(diff);
    diff = Math.floor(diff / 24);
    if (diff < 30) return diff + ' day' + pluralize(diff);
    diff = Math.floor(diff / 30);
    if (diff < 12) return diff + ' month' + pluralize(diff);
    diff = Math.floor(diff / 12);
    return diff + ' year' + pluralize(diff);
    function pluralize(value) {
        if (value !== 1) return 's';
        else return '';
    }
}