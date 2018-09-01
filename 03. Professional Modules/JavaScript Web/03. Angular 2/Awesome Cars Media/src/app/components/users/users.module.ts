import { NgModule } from '@angular/core'
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';


import { AllUsersComponent } from './all-users/all-users.component';
import { UsersService } from '../../core/services/users.service';
import { UsersRoutingModule } from './users.routing';
import { EditUserComponent } from './edit-user/edit-user.component';

@NgModule({
    declarations: [
        AllUsersComponent,
        EditUserComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        UsersRoutingModule
        
    ],
    providers: [
        UsersService
    ]
})

export class UsersModule { }