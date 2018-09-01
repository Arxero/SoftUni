import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PostService } from '../../../core/services/posts.service';
import { Observable } from 'rxjs';
import { PostModel } from '../../../core/models/post-models/post.model';

@Component({
    selector: 'app-posts-by-map',
    templateUrl: './posts-by-map.component.html',
    styleUrls: ['./posts-by-map.component.css']
})
export class PostsByMapComponent implements OnInit {
    //posts: Observable<PostModel[]>
    posts: any
    map : string

    constructor(
        private route: ActivatedRoute,
        private postService: PostService,
    ) { }

    ngOnInit() {
        this.map = this.route.snapshot.params['name']
        this.posts = this.postService.getAllPostsByMap(this.map)
    }

}
