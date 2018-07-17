import React, { Component } from 'react'
import List from './list';
import ItemsForm from './itemsForm';

export default class Container extends Component {
    constructor(props) {
        super(props)

        this.state = {
            items: []
        }
    }

    addItem = item => {
        this.setState(prevState => {
            let items = prevState.items

            items.push({
                id: items.length + 1,
                name: item
            })
            return { items }
        })
    }
    render() {
        return (
            <div>
                <h1>My Page</h1>
                {this.props.children}
                <List items={this.state.items} />
                <ItemsForm addItem={this.addItem} />
            </div>
        )
    }
}