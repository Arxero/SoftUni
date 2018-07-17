import React, { Component } from 'react'

class Roster extends Component {
    render = () => {
        const images = this.props.images.map(i => (
            <div key={i.id} className='roster-image-container'>
                <img src={i.url} onClick={() => this.props.select(i.id)} alt=''/>
            </div>
        ))
        return (
            <section id="roster">
                {images}
            </section>
        )
    }
}

export default Roster