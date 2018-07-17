import React, { Component } from 'react'
import './welcome.css'
import Button from '../components lab/Button'
import Timer from '../components lab/Timer'

class Welcome extends Component {
    render() {
        let title = this.props.title || 'Title'
        let subtitle = this.props.subtitle || 'Subtitle'
        let welcomeClass = 'Welcome-' + (this.props.welcomeClass || 'default')
        return (
            <div className={welcomeClass}>
                <Button text='Some Text' className='Button-main'/>
                <br/>
                <Timer/>
                <h1>{title}</h1>
                <h2>{subtitle}</h2>
            </div> 
        )
    }
}

export default Welcome

