import { NgModule } from '@angular/core'
import { FormsModule } from '@angular/forms';
import { AuthService } from './auth.service';
import { authComponents } from '.';

@NgModule({
    declarations: [
       ...authComponents
    ],
    imports: [
        FormsModule
    ],
    providers: [
        AuthService
    ]
})

export class AuthModule { }