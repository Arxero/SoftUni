import React, { Component } from 'react'

export default class List extends Component {
    render() {
        let items = this.props.items || []

        return (
          <ul>
            {items.map(item => <li key={item.id}>{item.name}</li>)}
          </ul>
        )
    }
}