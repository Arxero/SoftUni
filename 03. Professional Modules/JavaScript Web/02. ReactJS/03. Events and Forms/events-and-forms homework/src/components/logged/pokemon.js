import React, { Component } from 'react'
import '../styles/gallery.css'

export default class Pokemon extends Component {
    render() {
        return (
            <div className="responsive" key={this.props}>
                <div className="gallery">
                    <a href={this.props.item.pokemonImg} target="_blank">
                        <img src={this.props.item.pokemonImg} alt={this.props.item.pokemonName} width="600" height="400" />
                    </a>
                    <div className="desc">
                        <strong>{this.props.item.pokemonName}</strong>
                        <p>{this.props.item.pokemonInfo}</p>
                    </div>
                </div>
            </div>
        )
    }
}