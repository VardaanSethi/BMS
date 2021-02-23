import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie } from 'src/app/Model/movie';
import { MovieService } from 'src/app/service/movie.service';

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrls: ['./movie-detail.component.sass']
})
export class MovieDetailComponent implements OnInit {
  movie:Movie = null;
  isValid: boolean = false;
  constructor(private activeRoute:ActivatedRoute,
              private movieService:MovieService) { }

  ngOnInit(): void {
    this.activeRoute.params.subscribe(
      params=>{
        this.movieService.getMovie(+params['id']).subscribe(
          response=>{
            this.movie = response;
            this.isValid = true;
          }
        )
      }
    )
  }
}
