import React from 'react'
import { Route } from 'react-router-dom'


const Footer = () => (
    <div>
        <div>My classy footer 2018 C</div>
        <Route path='/random' render={() => (
            <h2>Random Custom Footer</h2>
        )} />
    </div>
)

export default Footer