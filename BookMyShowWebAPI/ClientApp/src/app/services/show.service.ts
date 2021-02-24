import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Movie } from '../models/movie.model';

@Injectable({
  providedIn: 'root'
})
export class ShowService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/show';

  getShowsByTheater(theaterId, movieId){
    return this.http.get(`${this.baseURL}/theater/${theaterId}/movie/${movieId}`);
  }
}
