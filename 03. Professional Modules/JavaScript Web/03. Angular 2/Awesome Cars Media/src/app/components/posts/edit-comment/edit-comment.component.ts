import { Component, OnInit } from '@angular/core';
import { CommentModel } from '../../../core/models/comment-models/comment.model';
import { CommentsService } from '../../../core/services/comments.service';
import { ToastrService } from 'ngx-toastr';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'app-edit-comment',
    templateUrl: './edit-comment.component.html',
    styleUrls: ['./edit-comment.component.css']
})
export class EditCommentComponent implements OnInit {
    commentModel: CommentModel

    constructor(
        private commentService: CommentsService,
        private toastr: ToastrService,
        private route: ActivatedRoute,
        private router: Router, ) { }

    ngOnInit() {
        this.commentService.getCommentDetails(this.route.snapshot.params['id'])
            .subscribe(data => {
                this.commentModel = data
            })
    }

    editComment() {
        this.commentService.editComment(this.commentModel._id, this.commentModel).subscribe(() => {
            this.toastr.success('Comment Edited Successfully!', 'Success!')
            this.router.navigate(['/'])
        })
    }

}
