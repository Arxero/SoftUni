import { NgModule } from '@angular/core'
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { NgxPaginationModule } from 'ngx-pagination'

import { AddPostComponent } from './add-post/add-post.component';
import { AllPostsComponent } from './all-posts/all-posts.component';
import { PostDetailsComponent } from './post-details/post-details.component';

import { PostsRoutingModule } from './posts.routing';
import { PostService } from '../../core/services/posts.service';
import { MypostsComponent } from './myposts/myposts.component';
import { EditPostComponent } from './edit-post/edit-post.component';
import { PostsByMapComponent } from './posts-by-map/posts-by-map.component';
import { PostsByAuthorComponent } from './posts-by-author/posts-by-author.component';
import { CommentsService } from '../../core/services/comments.service';
import { EditCommentComponent } from './edit-comment/edit-comment.component';

@NgModule({
    declarations: [
        AddPostComponent,
        AllPostsComponent,
        PostDetailsComponent,
        MypostsComponent,
        EditPostComponent,
        PostsByMapComponent,
        PostsByAuthorComponent,
        EditCommentComponent,
    ],
    imports: [
        CommonModule,
        FormsModule,
        PostsRoutingModule,
        NgxPaginationModule
    ],
    providers: [
        PostService,
        CommentsService
    ]
})

export class PostsModule { }