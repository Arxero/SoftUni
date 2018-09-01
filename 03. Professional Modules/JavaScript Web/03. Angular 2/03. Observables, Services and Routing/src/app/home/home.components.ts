import { Component, OnInit } from '@angular/core';
import { HomeService } from './home.service';
import { GitHubProfile } from './github.profile.model';
import { Router } from '@angular/router';


@Component({
    selector: 'home',
    template: '<h1 *ngIf="profile">{{profile.login}} from {{profile.location}}</h1>',
    providers: [HomeService]
})
export class HomeComponent implements OnInit {
    profile: GitHubProfile

    constructor(
        private homeService: HomeService) {
    }

    ngOnInit() {
        this.homeService
            .getGitHubProfile('arxero')
            .subscribe(data => this.profile = data)
    }

}