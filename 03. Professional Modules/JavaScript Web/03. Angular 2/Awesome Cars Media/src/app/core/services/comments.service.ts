import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { AuthService } from './auth.service';
import { UserModel } from '../models/auth-models/user.model';
import { CommentModel } from '../models/comment-models/comment.model';




const commentsUrl = 'https://baas.kinvey.com/appdata/kid_B1xYqYVH7/comments'


@Injectable({
    providedIn: 'root'
})

export class CommentsService {
    constructor(private http: HttpClient,
        private authService: AuthService, ) { }


    createComment(body: Object) {
        return this.http.post(commentsUrl, body)
    }

    getAllCommentsByPostId(id: string) {
        return this.http.get<CommentModel[]>(commentsUrl + `?query={"postId":"${id}"}`)
    }

    deleteCommentById(id: string) {
        return this.http.delete(commentsUrl + '/' + id)
    }

    editComment(id: string, body: CommentModel) {
        return this.http.put(commentsUrl + '/' + id, body)
    }

    getCommentDetails(id: string) {
        return this.http.get<CommentModel>(commentsUrl + '/' + id)
    }



}