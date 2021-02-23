import { Component, OnInit, Input, OnChanges } from '@angular/core';
import { TheaterService } from 'src/app/service/theater.service';
import { Theater } from 'src/app/Model/theater';
import { ShowService } from 'src/app/service/show.service';
import { ScreenService } from 'src/app/service/screen.service';
import { Booking } from 'src/app/Model/booking';
import { BookingService } from 'src/app/service/booking.service';

@Component({
  selector: 'app-show-theater',
  templateUrl: './show-theater.component.html',
  styleUrls: ['./show-theater.component.sass']
})
export class ShowTheaterComponent implements OnInit {
  theaters: Theater[];
  selectedTheaterId: number;
  showsByTheater: any = [];
  @Input() movieId: number;
  isAvailableShows: boolean = false;
  seats: { NoOfSeats: number, TheaterId: number };
  noOfAvailableSeats: number;
  arrayOfSeats: number[] = new Array()
  selectedSeatId: number;
  ticketPrice: number = 350;
  selectedShowId: number;
  selectedShowTime: any;
  bookedId : number;
  bookingDetails: any=null;

  constructor(private theaterService: TheaterService, private showsService: ShowService, private screenService: ScreenService, private bookingService: BookingService) { }

  ngOnInit(): void {
    this.theaterService.getTheaters().subscribe(
      response => {
        this.theaters = response;
      }
    )
  }
  getTheaterId(event) {
    this.selectedTheaterId = event.target.value;
    this.screenService.getNumberOfSeats(this.selectedTheaterId).subscribe(
      response => {
        this.seats = response;
        this.noOfAvailableSeats = <number>(this.seats.NoOfSeats);
        this.arrayOfSeats = new Array(this.noOfAvailableSeats);
      }
    )
  }

  getShowsByTheater() {
    this.showsService.getShowsByTheater(this.selectedTheaterId, this.movieId).subscribe(
      response => {
        this.showsByTheater = response;
        this.isAvailableShows = true;
      }
    )
  }

  getSeatId(event) {
    this.selectedSeatId = event.target.value;
  }

  getShowDetails(showId, showTiming) {
    this.selectedShowId = showId;
    this.selectedShowTime = showTiming;
  }

  bookingTicket(selectedSeatId, ticketPrice) {
    var booking = new Booking(this.selectedTheaterId, this.selectedShowId, selectedSeatId * ticketPrice, selectedSeatId, this.selectedShowTime);
    this.bookingService.postBooking(booking).subscribe(
      response => {
        this.bookedId = <number>response;
        this.getAllBookings();
      }
    )
  }

  getAllBookings(){
    this.bookingService.getBookings(this.bookedId).subscribe(
      response=>{
        this.bookingDetails = response;
        console.log(this.bookingDetails);
      }
    ) 
  }
}