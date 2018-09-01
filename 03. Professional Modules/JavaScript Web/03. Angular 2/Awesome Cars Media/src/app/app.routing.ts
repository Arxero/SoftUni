import { NgModule } from '@angular/core';
import { RouterModule, Routes, } from '@angular/router';

//Guards
import { AuthGuard } from './core/guards/auth.guard';

//Modules
import { PostsModule } from './components/posts/posts.module';
import { UsersModule } from './components/users/users.module';

//Components
import { AllPostsComponent } from './components/posts/all-posts/all-posts.component';
import { RegisterFormComponent } from './components/authentication/register-form/register-form.component';
import { LoginFormComponent } from './components/authentication/login-form/login-form.component';
import { TosComponent } from './components/authentication/tos/tos.component';
import { ProfileComponent } from './components/authentication/profile/profile.component';



const routes: Routes = [
    { path: '', component: AllPostsComponent },
    { path: 'register', component: RegisterFormComponent },
    { path: 'login', component: LoginFormComponent },
    { path: 'tos', component: TosComponent },
    { path: 'profile', component: ProfileComponent, canActivate: [AuthGuard] },
    { path: 'posts', loadChildren: () => PostsModule, canActivate: [AuthGuard] },
    { path: 'users', loadChildren: () => UsersModule, canActivate: [AuthGuard] },
]

@NgModule({
    imports: [ RouterModule.forRoot(routes)],
    exports: [ RouterModule ]
  })
export class AppRoutingModule {  }