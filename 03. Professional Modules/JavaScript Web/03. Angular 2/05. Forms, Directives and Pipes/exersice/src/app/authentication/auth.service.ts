import { Injectable } from '@angular/core'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { LoginModel } from '../models/login.model';
import { RegisterModel } from '../models/register.model';

const appKey = "kid_HJk-AU_Vm"
const appSecret = "55efca86b6e043a58384d3607f6579fe"
const registerUrl = `https://baas.kinvey.com/user/${appKey}`
const loginUrl = `https://baas.kinvey.com/user/${appKey}/login`
const logoutUrl = `https://baas.kinvey.com/user/${appKey}/_logout`

@Injectable()
export class AuthService {
    private currentAuthtoken: string
    constructor(private htpp: HttpClient) {

    }

    login(loginModel: LoginModel) {
        return this.htpp.post(loginUrl,
            JSON.stringify(loginModel), {
                headers: this.createAuthHeaders('Basic')
            })
    }

    register(registerModel: RegisterModel) {
        return this.htpp.post(registerUrl,
            JSON.stringify(registerModel), {
                headers: this.createAuthHeaders('Basic')
            })
    }

    logout() {
        return this.htpp.post(logoutUrl, {},
            { headers: this.createAuthHeaders('Kinvey') })
    }

    checkIfLoggedIn() {
        return this.currentAuthtoken === sessionStorage.getItem('authtoken')
    }

    get authtoken() {
        return this.currentAuthtoken
    }

    set authtoken(value: string) {
        this.currentAuthtoken = value
    }

    private createAuthHeaders(type: string): HttpHeaders {
        if (type === 'Basic') {
            return new HttpHeaders({
                'Authorization': 'Basic ' + btoa(appKey + ':' + appSecret),
                'Content-Type': 'application/json'
            })
        } else {
            return new HttpHeaders({
                'Authorization': 'Kinvey ' + sessionStorage.getItem('authtoken'),
                'Content-Type': 'application/json'
            })
        }
    }
}