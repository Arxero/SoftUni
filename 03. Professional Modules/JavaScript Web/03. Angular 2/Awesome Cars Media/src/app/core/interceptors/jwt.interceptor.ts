import {
    HttpResponse,
    HttpEvent,
    HttpHandler,
    HttpInterceptor,
    HttpRequest,
    HttpEventType,
} from '@angular/common/http'
import { Injectable } from '@angular/core'
import { Observable } from 'rxjs'
import { tap } from 'rxjs/operators'
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

const APP_KEY = 'kid_B1xYqYVH7'
const APP_SECRET = '594bd276ee66442f9da4d7d8d0f82097'
const APP_MASTER_SECRET = '97bcfdcb100143d598cda50062c924b7'
const ADMIN_ROLE = 'b040a5e2-6235-49e5-a2a2-a454ac722522'


@Injectable()
export class JwtInterceptor implements HttpInterceptor {

    constructor(
        private toastr: ToastrService,
        private router: Router,
        private authService: AuthService) { }


    intercept(request: HttpRequest<any>, next: HttpHandler)
        : Observable<HttpEvent<any>> {

        if (request.url.endsWith('/') || request.url.endsWith('login')) { // when we login or register
            request = request.clone({
                setHeaders: {
                    'Content-Type': 'application/json',
                    'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)
                }
            })
        } else if (request.method === 'GET' && request.url.endsWith('posts') || request.url.endsWith(ADMIN_ROLE)) { // when there is no logged in user or we admin/unadmin user
            request = request.clone({
                setHeaders: {
                    'Content-Type': 'application/json',
                    'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_MASTER_SECRET)
                }
            })
        } else {
            request = request.clone({ //always except both scenarious above
                setHeaders: {
                    'Content-Type': 'application/json',
                    'Authorization': "Kinvey " + this.authService.user().authtoken
                }
            })
        }



        return next.handle(request)
            .pipe(tap((res: any) => {
                if (res instanceof HttpResponse && res.url.endsWith('/')) {
                    this.saveUser(res.body)
                    this.toastr.success('You have successfully registered!', 'Success!')
                    this.router.navigate(['/'])
                } else if (res instanceof HttpResponse && res.url.endsWith('login')) {
                    if (request.body.remember) {
                        this.saveUserLocalStorage(res.body)
                    } else {
                        this.saveUser(res.body)
                    }
                    this.toastr.success('You have successfully logged in!', 'Success!')
                    this.router.navigate(['/'])
                } else if (res instanceof HttpResponse && res.url.endsWith('_logout')) {
                    sessionStorage.clear()
                    localStorage.clear()
                    this.toastr.success('You have successfully logged out!', 'Success!')
                    this.router.navigate(['/'])
                } else if (res instanceof HttpResponse && res.url.endsWith('posts') && res.statusText == 'Created') {
                    this.toastr.success('Post added successfully!', 'Success!')
                    this.router.navigate(['/'])
                }
                //  else if (this.authService.user()) { // first we need to make sure there is a user, this should be last
                //     if (res instanceof HttpResponse && res.url.endsWith(this.authService.user().id)) {
                //         sessionStorage.clear()
                //         this.toastr.success('You have successfully edited Your profile!', 'Success!')
                //         this.router.navigate(['/login'])
                //     }
                // }




            }))
    }

    private saveUser(data) {
        if (data._kmd.roles) { // in case user have been an admin
            if (data._kmd.roles.length > 0) { // in case user is admin atm
                sessionStorage.setItem('user', JSON.stringify({
                    'username': data.username,
                    'authtoken': data._kmd.authtoken,
                    'id': data._id,
                    'role': data._kmd.roles[0].roleId
                }))
            } else if (data._kmd.roles.length === 0) { // in case user have been an admin, but not anymore
                sessionStorage.setItem('user', JSON.stringify({
                    'username': data.username,
                    'authtoken': data._kmd.authtoken,
                    'id': data._id,
                }))
            }
        } else {
            sessionStorage.setItem('user', JSON.stringify({ // normal user
                'username': data.username,
                'authtoken': data._kmd.authtoken,
                'id': data._id,
            }))
        }
    }

    private saveUserLocalStorage(data) {
        if (data._kmd.roles) { // in case user have been an admin
            if (data._kmd.roles.length > 0) { // in case user is admin atm
                localStorage.setItem('user', JSON.stringify({
                    'username': data.username,
                    'authtoken': data._kmd.authtoken,
                    'id': data._id,
                    'role': data._kmd.roles[0].roleId
                }))
            } else if (data._kmd.roles.length === 0) { // in case user have been an admin, but not anymore
                localStorage.setItem('user', JSON.stringify({
                    'username': data.username,
                    'authtoken': data._kmd.authtoken,
                    'id': data._id,
                }))
            }
        } else {
            localStorage.setItem('user', JSON.stringify({ // normal user
                'username': data.username,
                'authtoken': data._kmd.authtoken,
                'id': data._id,
            }))
        }
    }
}