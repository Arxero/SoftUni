import React, { Component } from 'react'
import Textarea from './Textarea';
import '../../styles/chatbox.css'
import Bar from './Bar';
import MessageList from './MessageList';

export default class Chatbox extends Component {

    render() {
        let bar = ''
        if (sessionStorage.getItem('username') && sessionStorage.getItem('username') !== 'guest') {
            bar = <Bar username={sessionStorage.getItem('username')} image={sessionStorage.getItem('image')} status={sessionStorage.getItem('status')} />
        }
        return (
            <fieldset>
                <MessageList />
                {bar}
                <Textarea />
            </fieldset>
        )
    }
}