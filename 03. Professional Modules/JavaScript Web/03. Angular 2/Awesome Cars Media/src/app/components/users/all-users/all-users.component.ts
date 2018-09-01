import { Component, OnInit } from '@angular/core';
import { UsersService } from '../../../core/services/users.service';
import { UserModel } from '../../../core/models/auth-models/user.model';
import { Observable } from 'rxjs';
import { AuthService } from '../../../core/services/auth.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
    selector: 'app-all-users',
    templateUrl: './all-users.component.html',
    styleUrls: ['./all-users.component.css']
})
export class AllUsersComponent implements OnInit {
    //users: Observable<UserModel[]>
    users: UserModel[]

    constructor(
        private usersService: UsersService,
        private authService: AuthService,
        private toastr: ToastrService,
        private router: Router, ) { }

    ngOnInit() {
        //this.users = this.usersService.getAllUsers()
        this.usersService.getAllUsers().subscribe(data => {
            this.users = data

        })

    }

    deleteUser(id: string, username: string) {
        if (confirm(`DELETE user ${username}\nAre you sure about that?`)) {
            this.usersService.delete(id).subscribe(() => {
                this.toastr.success('User Deleted Successfully!', 'Success!')
                this.router.navigate(['/'])
            })
        }
    }

    adminUser(id: string, username: string) {
        if (confirm(`Admin user ${username}\nAre you sure about that?`)) {
            this.usersService.admin(id).subscribe(() => {
                this.toastr.success('User made an Admin Successfully!', 'Success!')
                this.router.navigate(['/'])
            })
        }
    }

    unAdminUser(id: string, username: string) {
        if (confirm(`UnAdmin user ${username}\nAre you sure about that?`)) {
            this.usersService.unAdmin(id).subscribe(() => {
                this.toastr.success('User Admin removed Successfully!', 'Success!')
                this.router.navigate(['/'])
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

}
