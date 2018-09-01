import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RegisterModel } from '../models/auth-models/register.model';
import { LoginModel } from '../models/auth-models/login.model';


const registerUrl = 'https://baas.kinvey.com/user/kid_B1xYqYVH7/'
const loginUrl = 'https://baas.kinvey.com/user/kid_B1xYqYVH7/login'
const logoutUrl = 'https://baas.kinvey.com/user/kid_B1xYqYVH7/_logout'
const editUrl = 'https://baas.kinvey.com/user/kid_B1xYqYVH7/'


@Injectable()
export class AuthService {
    constructor(private http: HttpClient) { }

    register(body: RegisterModel) {
        return this.http.post(registerUrl, body);
    }

    login(body: LoginModel) {
        return this.http.post(loginUrl, body)
    }

    logout(body: Object = {}) {
        return this.http.post(logoutUrl, body)
    }

    edit(body: Object) {
        return this.http.put(editUrl + this.user().id, body)
    }

    getUserById() {
        return this.http.get(editUrl + this.user().id)
    }

    isAuthenticated(): boolean {
        return (sessionStorage.getItem('user') || localStorage.getItem('user')) !== null
    }

    user() {
        return JSON.parse(sessionStorage.getItem('user') || localStorage.getItem('user'))
    }

}
