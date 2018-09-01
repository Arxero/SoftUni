import { Component, OnInit } from '@angular/core';
import { RegisterModel } from '../../../core/models/auth-models/register.model';
import { AuthService } from '../../../core/services/auth.service';

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.css']
})
export class RegisterFormComponent implements OnInit {
    model : RegisterModel
    emailRegex : string = '^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$'

  constructor(private authService: AuthService) {
      this.model = new RegisterModel('', '', '')
   }

  ngOnInit() {
  }

  register() {
      this.authService.register(this.model).subscribe()
  }
}
