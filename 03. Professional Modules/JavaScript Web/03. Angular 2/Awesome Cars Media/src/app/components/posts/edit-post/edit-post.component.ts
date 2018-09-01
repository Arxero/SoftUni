import { Component, OnInit } from '@angular/core';
import { PostModel } from '../../../core/models/post-models/post.model';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { PostService } from '../../../core/services/posts.service';
import { maps } from '../../../../assets/maps'

@Component({
    selector: 'app-edit-post',
    templateUrl: './edit-post.component.html',
    styleUrls: ['./edit-post.component.css']
})
export class EditPostComponent implements OnInit {
    model: PostModel
    maps : any = maps

    constructor(
        private route: ActivatedRoute,
        private postService: PostService,
        private router: Router,
        private toastr: ToastrService
    ) { }

    ngOnInit() {
        this.postService.getPostDetails(this.route.snapshot.params['id'])
        .subscribe(data => {
            this.model = data
        })
    }

    edit() {
        this.postService.editPost(this.model._id, this.model).subscribe(() => {
            this.toastr.success('Post Edited Successfully!', 'Success!')
            this.router.navigate(['/'])
        })
    }
}
