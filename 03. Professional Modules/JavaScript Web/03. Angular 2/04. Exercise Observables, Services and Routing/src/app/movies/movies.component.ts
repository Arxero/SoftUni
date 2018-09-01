import { Component, OnInit } from '@angular/core';
import { MoviesService } from '../service/movies.service';

@Component({
    selector: 'app-movies',
    templateUrl: './movies.component.html',
    styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {
    popular: Object
    theaters: Object
    kids: Object
    drama: Object
    searchResults: Object
    isSearching: boolean = false

    constructor(private moviesService: MoviesService) { }

    search(query) {
        this.moviesService.findAMovie(query.search).subscribe(data => {
            this.searchResults = data
            this.isSearching = true
        })
    }

    ngOnInit() {
        this.moviesService.getPopular().subscribe(data => {
            this.popular = data
        })

        this.moviesService.getInTheaters().subscribe(data => {
            this.theaters = data
        })

        this.moviesService.getKids().subscribe(data => {
            this.kids = data
        })

        this.moviesService.getDrama().subscribe(data => {
            this.drama = data
        })
    }

}
