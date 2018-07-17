import React, { Component } from 'react'

class Details extends Component {
    render = () => {
        let content = <i>Select a character</i>
        if (this.props.bio) {
            content = (
                <div>
                    <div className='image'>
                        <img src={this.props.url} alt='' />
                    </div>
                    <div className='info'>
                        <p>Name: <strong>{this.props.name}</strong></p>
                        <p>Bio: {this.props.bio}</p>
                    </div>
                </div>
            )
        }
        return (
            <section id='bio'>
                {content}
            </section>
        )
    }
}

export default Details