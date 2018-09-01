import { Component, OnInit } from '@angular/core';
import { LoginModel } from '../../../core/models/auth-models/login.model';
import { AuthService } from '../../../core/services/auth.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
    model : LoginModel

  constructor(private authService: AuthService) {
      this.model = new LoginModel('', '')
   }

  ngOnInit() {
  }


  login() {
      this.authService.login(this.model).subscribe()
  }
}
