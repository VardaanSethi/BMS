import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Theater } from '../Model/theater';

@Injectable({
  providedIn: 'root'
})
export class TheaterService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/theater';

  getTheaters(){
    return this.http.get<Theater[]>(this.baseURL);
  }
}
