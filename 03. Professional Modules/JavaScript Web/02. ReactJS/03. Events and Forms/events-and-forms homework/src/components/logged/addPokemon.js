import React, { Component } from 'react'
import '../styles/form.css'

export default class AddPokemon extends Component {
    constructor(props) {
        super(props)

        this.state = {
            pokemon: {

            }
        }
    }

    onInputChanged = event => {
        let pokemon = this.state.pokemon
        let inputName = event.target.name
        let inputValue = event.target.value
        pokemon[inputName] = inputValue

        this.setState({
            pokemon: Object.assign(this.state.pokemon, pokemon)
        })
       

    }

    onFormSubmit = event => {
        event.preventDefault()

        fetch('http://localhost:5000/pokedex/create', {
            method: 'POST',
            body: JSON.stringify(this.state.pokemon),
            headers: {
                'Content-Type': 'application/json'
            }
        }).then(data => data.json()
        ).then(res => {
            this.props.updateRoster(res)
        }).catch(err => console.log(err))
    }
    
    render() {
        return (
            <form className="modal-content" onSubmit={this.onFormSubmit}>
                
                <div className="container">
                    <h1>Add Pokemon</h1>
                    <hr />
                    <label><b>Name</b></label>
                    <input type="text" placeholder="Enter Name" name="pokemonName" required onChange={this.onInputChanged} />

                    <label><b>Image</b></label>
                    <input type="text" placeholder="Enter Image" name="pokemonImg" required onChange={this.onInputChanged} />

                    <label><b>Info</b></label>
                    <input type="text" placeholder="Enter Info" name="pokemonInfo" required onChange={this.onInputChanged} />


                    <div className="clearfix">
                        <button type="button" className="cancelbtn">Cancel</button>
                        <button type="submit" className="signupbtn">Add</button>
                    </div>
                </div>
            </form>
        )
    }
}

