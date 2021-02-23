import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Movie } from '../Model/movie';

@Injectable({
  providedIn: 'root'
})
export class ShowService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/show';

  getShowsByTheater(theaterId, movieId):Observable<Movie>{
    return this.http.get<Movie>(`${this.baseURL}/showbytheater/${theaterId}/movie/${movieId}`);
  }
}
