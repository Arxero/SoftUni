import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../../core/services/auth.service';
import { Observable } from 'rxjs';
import { PostModel } from '../../../core/models/post-models/post.model';
import { PostService } from '../../../core/services/posts.service';

@Component({
    selector: 'app-all-posts',
    templateUrl: './all-posts.component.html',
    styleUrls: ['./all-posts.component.css']
})
export class AllPostsComponent implements OnInit {
    //posts: Observable<PostModel[]>
    posts: PostModel[]
    pageSize: number = 12
    currentPage: number = 1

    constructor(
        public authService: AuthService,
        private postService: PostService,
    ) { }

    ngOnInit() {
        this.postService.getAllPosts().subscribe(data => {
            this.posts = data
        })
        // this.posts = this.postService.getAllPosts()
    }

    pageChanged(page) {
        this.currentPage = page
    }

}
