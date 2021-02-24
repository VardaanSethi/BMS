import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Booking } from '../models/booking.model';

@Injectable({
  providedIn: 'root'
})
export class BookingService {

  constructor(private http:HttpClient) { }

  readonly baseURL = 'https://localhost:5001/api/booking';

  getBookings(id){
    return this.http.get(this.baseURL+`/${id}`);
  }
  postBooking(booking){
    return this.http.post(this.baseURL, booking);
  }
}
