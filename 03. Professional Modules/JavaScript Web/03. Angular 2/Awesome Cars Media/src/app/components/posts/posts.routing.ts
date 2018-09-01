import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddPostComponent } from './add-post/add-post.component';
import { AuthGuard } from '../../core/guards/auth.guard';
import { MypostsComponent } from './myposts/myposts.component';
import { PostDetailsComponent } from './post-details/post-details.component';
import { EditPostComponent } from './edit-post/edit-post.component';
import { PostsByMapComponent } from './posts-by-map/posts-by-map.component';
import { PostsByAuthorComponent } from './posts-by-author/posts-by-author.component';
import { EditCommentComponent } from './edit-comment/edit-comment.component';


const postsRoutes: Routes = [
    { path: 'add', component: AddPostComponent },
    { path: 'myposts', component: MypostsComponent },
    { path: 'edit/:id', component: EditPostComponent },
    { path: 'details/:id', component: PostDetailsComponent },
    { path: 'map/:name', component: PostsByMapComponent },
    { path: 'author/:name', component: PostsByAuthorComponent},
    { path: 'comment/edit/:id', component: EditCommentComponent},
]

@NgModule({
    imports: [
        RouterModule.forChild(postsRoutes)
    ],
    exports: [
        RouterModule
    ]
})

export class PostsRoutingModule { }