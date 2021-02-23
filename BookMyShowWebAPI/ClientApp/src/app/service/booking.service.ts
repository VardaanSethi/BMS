import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Booking } from '../Model/booking';

@Injectable({
  providedIn: 'root'
})
export class BookingService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/booking';

  getBookings(id){
    return this.http.get<Booking>(this.baseURL+`/${id}`);
  }
  postBooking(booking){
    return this.http.post(this.baseURL, booking);
  }
}
