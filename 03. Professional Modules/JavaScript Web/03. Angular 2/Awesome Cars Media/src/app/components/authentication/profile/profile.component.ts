import { Component, OnInit } from '@angular/core';
import { RegisterModel } from '../../../core/models/auth-models/register.model';
import { AuthService } from '../../../core/services/auth.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
    selector: 'app-profile',
    templateUrl: './profile.component.html',
    styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
    model: Object

    constructor(
        private authService: AuthService,
        private toastr: ToastrService,
        private router: Router,) {
        //this.model = new RegisterModel('', '', '')
    }

    ngOnInit() {
        this.authService.getUserById()
            .subscribe(data => {
                this.model = data
            })
    }

    edit() {
        this.authService.edit(this.model).subscribe()
        this.toastr.success('You have successfully edited Your profile!', 'Success!')
        sessionStorage.clear()
        this.router.navigate(['/login'])
    }

}
