import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ScreenService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/screen/seatsbytheater';

  getNumberOfSeats(theaterId){
    return this.http.get<{NoOfSeats:number, TheaterId:number}>(`${this.baseURL}/${theaterId}`);
  }
}