import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Theater } from '../models/theater.model';

@Injectable({
  providedIn: 'root'
})
export class TheaterService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/theater';

  getTheaters(){
    return this.http.get(this.baseURL);
  }
}
