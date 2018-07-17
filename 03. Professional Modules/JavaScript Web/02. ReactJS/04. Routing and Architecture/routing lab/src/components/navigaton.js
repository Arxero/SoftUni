import React from 'react'
import { Link } from 'react-router-dom'

const Navigaton = () => (
    <div className='menu'>
        <Link to='/home'>Home</Link>
        <Link to='/all'>All</Link>
        <Link to='/add'>Add</Link>
    </div>
)

export default Navigaton