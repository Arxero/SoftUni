import React from 'react'
import { Link } from 'react-router-dom'
import '../../styles/chatbox.css'

const Bar = props => (
    <div id='barDefault'>
        <Link to='/profile'><img src={props.image ? props.image : 'https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/f8/f8de58eb18a0cad87270ef1d1250c574498577fc_full.jpg'} alt="noimage"/></Link>
        <p>{props.username}</p>
        <p id='status'>{props.status}</p>
    </div>
)

export default Bar
