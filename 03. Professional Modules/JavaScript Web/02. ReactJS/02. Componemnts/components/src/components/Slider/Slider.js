import React, { Component } from 'react'
import left from '../Slider/left.png'
import right from '../Slider/right.png'
import fetcher from '../../fetcher'

const EPISODE_ENDPOINT = '/episodePreview/'

class Slider extends Component {
    constructor(props) {
        super(props)

        this.state = {
            url: null,
            id: null
        }
    }

    fetchEpisode = id => 
    fetcher.get(EPISODE_ENDPOINT + id, data => this.setState(data))

    componentDidMount = () => {
        this.fetchEpisode(0)
    }

    otherEpisode = id => {
        fetcher.get(EPISODE_ENDPOINT + id, data => this.setState(data))
    }

    // updateEpisode = id => {
    //     fetcher.get(EPISODE_ENDPOINT + id, data => this.setState(data))
    // }

    render = () => (
        <section id='slider'>
            <img className='button' src={left} title='previous' alt='nav' onClick={() => this.otherEpisode(this.state.id - 1)}/>
            <div className='image-container'>
                <img src={this.state.url} alt='episode'/>
            </div>
            <img className='button' src={right} title='next' alt='nav' onClick={() => this.otherEpisode(this.state.id + 1)}/>
        </section>
    )

}

export default Slider 