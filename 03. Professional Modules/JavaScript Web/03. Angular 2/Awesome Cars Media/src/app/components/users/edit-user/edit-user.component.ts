import { Component, OnInit } from '@angular/core';
import { UsersService } from '../../../core/services/users.service';
import { Observable } from 'rxjs';
import { UserModel } from '../../../core/models/auth-models/user.model';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AllPostsComponent } from '../../posts/all-posts/all-posts.component';

@Component({
    selector: 'app-edit-user',
    templateUrl: './edit-user.component.html',
    styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent implements OnInit {
    model: UserModel
    selectedUsername: string = ''

    constructor(
        private usersService: UsersService,
        private route: ActivatedRoute,
        private router: Router,
        private toastr: ToastrService) {
        this.model = new UserModel('', '', '', '', '', '')
    }

    ngOnInit() {
        this.usersService.getUserById(this.route.snapshot.params['id'])
            .subscribe(data => {
                this.model = data
                this.selectedUsername = data['username']
            })
    }

    edit() {
        this.usersService.edit(this.model, this.model['_id']).subscribe()
        this.toastr.success('User Edited Successfully!', 'Success!')
        this.router.navigate(['/'])
        //this.router.navigate(['/users/all'])
        //this.router.navigateByUrl('/tos', { skipLocationChange: true });
        //this.router.navigate(["/users/all"]);
    }

}
