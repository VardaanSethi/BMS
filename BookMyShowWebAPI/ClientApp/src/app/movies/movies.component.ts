import { Component, OnInit, Input } from '@angular/core';
import { MovieService } from '../service/movie.service';
import { Movie } from '../Model/movie';
import { Router } from '@angular/router';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.sass']
})
export class MoviesComponent implements OnInit {
  movies:Movie[];

  constructor(private movieService:MovieService) { }

  ngOnInit(): void {
    this.movieService.getMovies().subscribe(
      response=>{
        this.movies = response;
      }
    )
  }
}
