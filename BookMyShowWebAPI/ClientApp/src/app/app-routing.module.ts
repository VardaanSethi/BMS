import { NgModule, ModuleWithProviders } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MoviesComponent } from './movies/movies.component';
import { MovieDetailComponent } from './movies/movie-detail/movie-detail.component';
import { ShowTheaterComponent } from './movies/movie-detail/show-theater/show-theater.component';

const routes: Routes = [
  {path : '', component : MoviesComponent},
  {path :'movie/:id', component : MovieDetailComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
