import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { PostModel } from '../../../core/models/post-models/post.model';
import { ActivatedRoute, Router } from '@angular/router';
import { PostService } from '../../../core/services/posts.service';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../../../core/services/auth.service';
import { CreateCommentModel } from '../../../core/models/comment-models/create-comment.model';
import { CommentsService } from '../../../core/services/comments.service';
import { CommentModel } from '../../../core/models/comment-models/comment.model';

@Component({
    selector: 'app-post-details',
    templateUrl: './post-details.component.html',
    styleUrls: ['./post-details.component.css']
})
export class PostDetailsComponent implements OnInit {
    // post: Observable<PostModel>
    p: PostModel
    model: CreateCommentModel
    comments: Observable<CommentModel[]>
    postId: string


    constructor(
        private route: ActivatedRoute,
        private postService: PostService,
        private commentsService: CommentsService,
        private toastr: ToastrService,
        private router: Router,
        public authService: AuthService) {
        this.postId = this.route.snapshot.params['id']
        this.model = new CreateCommentModel('', this.postId, authService.user().username, )
    }

    
    ngOnInit() {
        // this.post = this.postService.getPostDetails(this.postId)
        this.postService.getPostDetails(this.postId).subscribe(data => {
            this.p = data
        })

        this.comments = this.commentsService.getAllCommentsByPostId(this.postId)

    }


    createComment() {
        this.commentsService.createComment(this.model).subscribe(() => {
            //this.toastr.success('Post Added Successfully!', 'Success!')
            this.comments = this.commentsService.getAllCommentsByPostId(this.postId)
            this.model.comment = ''
            //this.router.navigate([`/posts/details/${this.postId}`])
        })
    }


    deletePost(id: string, postName: string) {
        if (confirm(`DELETE post: ${postName}\nAre you sure about that?`)) {
            this.postService.deletePost(id).subscribe(() => {
                this.toastr.success('Post Deleted Successfully!', 'Success!')
                this.router.navigate(['/'])
            })
        }
    }


    deleteComment(id: string) {
        if (confirm(`DELETE Comment\nAre you sure about that?`)) {
            this.commentsService.deleteCommentById(id).subscribe(() => {
                this.toastr.success('Comment Deleted Successfully!', 'Success!')
                this.comments = this.commentsService.getAllCommentsByPostId(this.postId)
            })
        }
    }


    dateFormat(date: Object) {
        let options = {
            year: 'numeric',
            month: 'short',
            day: 'numeric',
            minute: 'numeric',
            hour: 'numeric'
        }
        return new Date(date['ect']).toLocaleString('en-GB', options).replace(',', ' @')
    }


    calcTime(dateIsoFormat) {
        let diff = +new Date - (+new Date(dateIsoFormat));
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
}

