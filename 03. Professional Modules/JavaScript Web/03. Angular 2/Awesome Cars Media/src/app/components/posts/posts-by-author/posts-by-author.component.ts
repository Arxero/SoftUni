import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PostService } from '../../../core/services/posts.service';

@Component({
    selector: 'app-posts-by-author',
    templateUrl: './posts-by-author.component.html',
    styleUrls: ['./posts-by-author.component.css']
})
export class PostsByAuthorComponent implements OnInit {
    //posts: Observable<PostModel[]>
    posts: any
    author: string

    constructor(
        private route: ActivatedRoute,
        private postService: PostService,
    ) { }

    ngOnInit() {
        this.author = this.route.snapshot.params['name']
        this.posts = this.postService.getAllPostsByAuthor(this.author)
    }

}
