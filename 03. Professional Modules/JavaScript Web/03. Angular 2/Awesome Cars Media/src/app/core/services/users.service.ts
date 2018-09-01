import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { AuthService } from './auth.service';
import { UserModel } from '../models/auth-models/user.model';




const usersUrl = 'https://baas.kinvey.com/user/kid_B1xYqYVH7'


@Injectable({
    providedIn: 'root'
})

export class UsersService {
    constructor(private http: HttpClient,
        private authService: AuthService,) { }

    getAllUsers() {
        return this.http.get<UserModel[]>(usersUrl)
    }

    getUserById(id: string) {
        return this.http.get<UserModel>(usersUrl + '/' + id)
    }

    edit(body: Object, id: string) {
        return this.http.put(usersUrl + '/' + id, body)
    }

    delete(id: string){
        return this.http.delete(usersUrl + '/' + id + '?hard=true')
    }

    admin(id: string) {
        return this.http.put(usersUrl + '/' + id + '/roles/' + this.authService.user().role, {})
    }

    unAdmin(id: string) {
        return this.http.delete(usersUrl + '/' + id + '/roles/' + this.authService.user().role, {})
    }

}