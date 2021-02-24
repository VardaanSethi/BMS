import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Movie } from '../models/movie.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private http: HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/movie';

  getMovies(){
    return this.http.get(this.baseURL);
  }

  getMovie(id:number){
    return this.http.get(this.baseURL+`/${id}`);
  }
}
