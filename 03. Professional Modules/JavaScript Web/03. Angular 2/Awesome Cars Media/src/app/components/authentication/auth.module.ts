import { NgModule } from '@angular/core'
import { FormsModule } from '@angular/forms'
import { CommonModule } from '@angular/common';
import { LoginFormComponent } from './login-form/login-form.component';
import { RegisterFormComponent } from './register-form/register-form.component';
import { AuthService } from '../../core/services/auth.service';
import { TosComponent } from './tos/tos.component';
import { AppRoutingModule } from '../../app.routing';
import { ProfileComponent } from './profile/profile.component';

@NgModule({
    declarations: [
        LoginFormComponent,
        RegisterFormComponent,
        TosComponent,
        ProfileComponent,
    ],
    imports: [
        FormsModule,
        CommonModule,
        AppRoutingModule
    ],
    providers: [
        AuthService
    ]

})

export class AuthModule { }