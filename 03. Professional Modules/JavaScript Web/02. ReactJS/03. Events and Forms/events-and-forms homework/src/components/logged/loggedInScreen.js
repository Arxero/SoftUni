import React, { Component } from 'react'
import '../styles/form.css'
import AddPokemon from './addPokemon'
import Pokemon from './pokemon'

export default class LoggedInScreen extends Component {
    constructor(props) {
        super(props)

        this.state = {
            pokemons: []
        }
    }

    updateRoster = newRoster => {
        this.setState({
            pokemons: newRoster
        })
    }

    componentDidMount() {
        fetch('http://localhost:5000/pokedex/pokedex')
            .then(data => data.json())
            .then(res => this.setState({ pokemons: res.pokemonColection }))
    }

    render() {
        return (
            <div>
                <AddPokemon updateRoster={this.updateRoster}/>
                {this.state.pokemons.map((p, i) => <Pokemon item={p} key={i + 1}/>)}
            </div>
        )
    }
}

