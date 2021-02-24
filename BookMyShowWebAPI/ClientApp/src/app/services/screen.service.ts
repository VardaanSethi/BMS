import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ScreenService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/screen/theater';

  getNumberOfSeats(theaterId){
    return this.http.get(`${this.baseURL}/${theaterId}`);
  }
}