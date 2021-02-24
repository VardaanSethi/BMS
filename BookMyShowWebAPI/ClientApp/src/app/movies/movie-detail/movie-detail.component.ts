import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie } from 'src/app/models/movie.model';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrls: ['./movie-detail.component.sass']
})
export class MovieDetailComponent implements OnInit {
  movie = null;
  isValid: boolean = false;
  constructor(private activeRoute:ActivatedRoute,
              private movieService:MovieService) { }

  ngOnInit(): void {
    this.activeRoute.params.subscribe(
      params=>{
        this.movieService.getMovie(+params['id']).subscribe(
          data=>{
            this.movie = data;
            this.isValid = true;
          }
        )
      }
    )
  }
}
