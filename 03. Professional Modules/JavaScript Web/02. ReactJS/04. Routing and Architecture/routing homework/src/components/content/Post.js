import React, { Component } from 'react'
import{ Link } from 'react-router-dom'
import '../../styles/post.css'



export default class Post extends Component {

    calcTime = () => {
        let dateIsoFormat = this.props._kmd.ect
        let diff = new Date() - (new Date(dateIsoFormat));
        diff = Math.floor(diff / 60000);
        if (diff < 1) return 'less than a minute';
        if (diff < 60) return diff + ' minute' + pluralize(diff);
        diff = Math.floor(diff / 60);
        if (diff < 24) return diff + ' hour' + pluralize(diff);
        diff = Math.floor(diff / 24);
        if (diff < 30) return diff + ' day' + pluralize(diff);
        diff = Math.floor(diff / 30);
        if (diff < 12) return diff + ' month' + pluralize(diff);
        diff = Math.floor(diff / 12);
        return diff + ' year' + pluralize(diff);
        function pluralize(value) {
            if (value !== 1) return 's';
            else return '';
        }

    }

    render = () => {
        return (
            <article className="post">
                        <div className="col rank">
                            <span>{this.props.index + 1}</span>
                        </div>
                        <div className="col thumbnail">
                            <a href={this.props.url}> <img src={this.props.imageUrl} alt=''/></a>
                        </div>
                        <div className="post-content">
                            <div className="title">
                                <a href={this.props.url}>{this.props.title}</a>
                            </div>
                            <div className="details">
                                <div className="info">
                                    {this.calcTime()}
                                </div>
                                <div className="controls">
                                    <ul>
                                        <li className="action"><Link className="commentsLink" to="/">comments</Link></li>
                                        <li className="action"><Link className="editLink" to="/">edit</Link></li>
                                        <li className="action"><Link className="deleteLink" to="/">delete</Link></li>
                                    </ul>
                                </div>

                            </div>
                        </div>
                    </article>
        )
    }
}
