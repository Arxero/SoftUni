import React, { Component } from 'react'
import Post from './Post'

const BASE_URL = "https://baas.kinvey.com/"
const APP_KEY = "kid_HJRtT9_fX"
const AUTH_HEADERS = {
    'Content-Type': 'application/json',
    'Authorization': "Kinvey " + sessionStorage.getItem('authtoken')
}


export default class PostList extends Component {
    constructor(props) {
        super(props)
        this.state = {
            posts: []
        }
    }


    getPosts = () => {
        fetch(BASE_URL + 'appdata/' + APP_KEY + '/posts', {
            method: 'GET',
            headers: AUTH_HEADERS,
        }).then(res => res.json()
            .then(data => {
                //console.log(data)
                this.setState({
                    posts: data
                })
            }))
    }

    componentDidMount =  () =>  this.getPosts()



    render = () => (
        <section id='viewCatalog'>
            {this.state.posts.map((p, i) => <Post key={p._id} index={i}{...p} />)}
        </section>
    )
}

