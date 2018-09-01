import { Component, OnInit } from '@angular/core';
import { PostModel } from '../../../core/models/post-models/post.model';
import { PostService } from '../../../core/services/posts.service';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-myposts',
    templateUrl: './myposts.component.html',
    styleUrls: ['./myposts.component.css']
})
export class MypostsComponent implements OnInit {
    //posts: Observable<PostModel[]>
    posts: PostModel[]
    pageTitle: string

    constructor(
        private postService: PostService,
    ) { }

    ngOnInit() {
        //this.posts = this.postService.getMyPosts()
        this.postService.getMyPosts().subscribe(data => {
            this.posts = data
            if (this.posts.length > 0) {
                this.pageTitle = 'Your Posts'
            } else if (this.posts.length == 0) {
                this.pageTitle = `You don't have any posts`
            }
        })
    }

}
