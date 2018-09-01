import { Component, OnInit } from '@angular/core';
import { CreatePostModel } from '../../../core/models/post-models/create-post.model';
import { PostService } from '../../../core/services/posts.service';
import { maps } from '../../../../assets/maps'
import { AuthService } from '../../../core/services/auth.service';

@Component({
    selector: 'app-add-post',
    templateUrl: './add-post.component.html',
    styleUrls: ['./add-post.component.css']
})
export class AddPostComponent implements OnInit {
    model: CreatePostModel
    maps: any = maps


    constructor(
        private postService: PostService,
        public authService: AuthService) {
        let author = authService.user().username
        this.model = new CreatePostModel('', '', '', '', author)
    }

    ngOnInit() {

    }

    create() {
        this.postService.createPost(this.model).subscribe()
    }

    // selectChange($event) {
    //     console.log($event);
    // }
}
