import { Routes, RouterModule } from '@angular/router'
import { ModuleWithProviders } from '@angular/core'
import { MoviesComponent } from './movies/movies.component';
import { MovieDetailsComponent } from './movie-details/movie-details.component';

const routes: Routes = [
    { path: '', component: MoviesComponent },
    { path: 'movie/:id', component: MovieDetailsComponent },
]

let theRoutes: ModuleWithProviders = RouterModule.forRoot(routes)
export { theRoutes }