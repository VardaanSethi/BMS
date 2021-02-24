import { Component, OnInit, Input } from '@angular/core';
import { MovieService } from '../services/movie.service';
import { Movie } from '../models/movie.model';
import { Router } from '@angular/router';
import { versions } from 'process';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.sass']
})
export class MoviesComponent implements OnInit {
  movies;

  constructor(private movieService:MovieService) { }

  ngOnInit(): void {
    this.movieService.getMovies().subscribe(
      data=>{
        this.movies = data;
      }
    )
  }
}
