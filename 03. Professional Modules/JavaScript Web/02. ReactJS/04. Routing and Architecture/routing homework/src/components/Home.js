import React, { Component } from 'react'
import { Route } from 'react-router-dom'
import '../styles/site.css'
import Menu from './Menu'
import Login from './user/Login'
import Register from './user/Register'
import Welcome from './Welcome'
import Catalog from './content/Catalog'



export default class Home extends Component {
    render() {
        return (
            <div className='content'>
                <Menu />
                <section>
                    <div className='welcome'>
                        <div className='signup'>
                            <Route path='/' exact component ={Login} />
                            <Route path='/' exact component ={Register} />
                        </div>
                        <Route path='/' exact component ={Welcome} />
                    </div>
                    <Route path='/catalog' exact component ={Catalog} />
                </section>
            </div>
        )
    }
}

