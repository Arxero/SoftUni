import React from 'react'
import Home from './components/home'
import AddCatFood from './components/add'
import AllCatFood from './components/all'
import { Route, Switch } from 'react-router-dom'

const AppRouter = () => (
    <div>
        <Switch>
            <Route path='/home' component={Home} />
            <Route path='/add' component={AddCatFood} />
            <Route path='/all' component={AllCatFood} />
        </Switch>
    </div>
)

export default AppRouter