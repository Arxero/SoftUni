import React, { Component } from 'react'

export default class ItemsForm extends Component {
    constructor(props) {
        super(props)

        this.state = {
            itemName: '',
            error: ''
        }
    }

    onInputChanged = event => {
        this.setState({
            itemName: event.target.value
        })
    }

    onSubmitClicked = event => {
        event.preventDefault()

        if (this.state.itemName.length === 0) {
            this.setState({ error: 'Non Emptry fields Allowed!' })
            return
        } else {
            this.props.addItem(this.state.itemName)
            this.setState({ error: '' })
        }
    }

    render() {
        return (
            <form onSubmit={this.onSubmitClicked}>
                <span>{this.state.error}</span>
                <br />
                <input type='text' name='name' onChange={this.onInputChanged} value={this.state.itemName} />
                <br />
                <input type="submit" />
            </form>
        )
    }
}