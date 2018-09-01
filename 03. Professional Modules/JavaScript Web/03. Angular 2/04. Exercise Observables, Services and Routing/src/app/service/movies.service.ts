import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Movies } from '../models/movies.model';
const apiKey = '14b2021cfe6f43f74b37f10d188974a5'

@Injectable({
    providedIn: 'root'
})
export class MoviesService {
    today: number = Number(new Date().toLocaleDateString().split('/')[1])
    currentMonth: number = Number(new Date().toLocaleDateString().split('/')[0])
    currentYear: string = new Date().toLocaleDateString().split('/')[2]

    path: string = 'https://api.themoviedb.org/3/'
    popular: string = 'discover/movie?sort_by=popularity.desc'
    inTheaters: string = `discover/movie?primary_release_date.gte=${this.currentYear}-${this.currentMonth}-${this.today}&primary_release_date.lte=${this.currentYear}-${this.currentMonth + 1}-${this.today}`
    kids: string = 'discover/movie?certification_country=US&certification.lte=G&sort_by=popularity.desc'
    drama: string = `discover/movie?with_genres=18&primary_release_year=${this.currentYear}`
    authentication: string = '&api_key='
    findById: string = 'movie/'
    movieAuth: string = '?api_key='
    search: string = 'search/movie?query='


    constructor(private httpClient: HttpClient) { }

    getPopular(): Observable<Movies> {
        return this.httpClient.get<Movies>(this.path + this.popular + this.authentication + apiKey)
    }

    getInTheaters(): Observable<Movies> {
        return this.httpClient.get<Movies>(this.path + this.inTheaters + this.authentication + apiKey)
    }

    getKids(): Observable<Movies> {
        return this.httpClient.get<Movies>(this.path + this.kids + this.authentication + apiKey)
    }

    getDrama(): Observable<Movies> {
        return this.httpClient.get<Movies>(this.path + this.drama + this.authentication + apiKey)
    }

    getMovie(id) {
        return this.httpClient.get(this.path + this.findById + id + this.movieAuth + apiKey)
    }

    findAMovie(name) {
        return this.httpClient.get(this.path + this.search + name + this.authentication + apiKey)
    }
}
