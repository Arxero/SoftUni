import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { CreatePostModel } from '../models/post-models/create-post.model';
import { PostModel } from '../models/post-models/post.model';
import { AuthService } from './auth.service';



const createAndGetUrl = 'https://baas.kinvey.com/appdata/kid_B1xYqYVH7/posts'


@Injectable({
    providedIn: 'root'
})

export class PostService {
    constructor(private http: HttpClient,
        private authService: AuthService) { }


    createPost(body: CreatePostModel) {
        return this.http.post(createAndGetUrl, body)
    }

    getAllPosts() {
        return this.http.get<PostModel[]>(createAndGetUrl)
    }

    getMyPosts() {
        let username = this.authService.user().username
        return this.http.get<PostModel[]>(createAndGetUrl + `?query={"author":"${username}"}`)
    }

    getPostDetails(id: string) {
        return this.http.get<PostModel>(createAndGetUrl + '/' + id)
    }

    deletePost(id: string){
        return this.http.delete(createAndGetUrl + '/' + id)
    }

    editPost(id: string, body: PostModel) {
        return this.http.put(createAndGetUrl + '/' + id, body)
    }

    getAllPostsByMap(map: string) {
        return this.http.get(createAndGetUrl + `?query={"map":"${map}"}`)
    }

    getAllPostsByAuthor(author: string) {
        return this.http.get(createAndGetUrl + `?query={"author":"${author}"}`)
    }
}