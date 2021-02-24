import { Component, OnInit, Input, OnChanges } from '@angular/core';
import { TheaterService } from 'src/app/services/theater.service';
import { Theater } from 'src/app/models/theater.model';
import { ShowService } from 'src/app/services/show.service';
import { ScreenService } from 'src/app/services/screen.service';
import { Booking } from 'src/app/models/booking.model';
import { BookingService } from 'src/app/services/booking.service';

@Component({
  selector: 'app-show-theater',
  templateUrl: './show-theater.component.html',
  styleUrls: ['./show-theater.component.sass']
})
export class ShowTheaterComponent implements OnInit {
  theaters: any;
  selectedTheaterId: number;
  showsByTheater: any = [];
  @Input() movieId: number;
  isAvailableShows: boolean = false;
  seats;
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
      data => {
        this.theaters = data;
      }
    )
  }
  getTheaterId(event) {
    this.selectedTheaterId = event.target.value;
    this.screenService.getNumberOfSeats(this.selectedTheaterId).subscribe(
      data => {
        this.seats = data;
        this.noOfAvailableSeats = <number>(this.seats.NoOfSeats);
        this.arrayOfSeats = new Array(this.noOfAvailableSeats);
      }
    )
  }

  getShowsByTheater() {
    this.showsService.getShowsByTheater(this.selectedTheaterId, this.movieId).subscribe(
      data => {
        this.showsByTheater = data;
        console.log(this.showsByTheater);
        this.isAvailableShows = true;
      }
    )
  }

  getSeatId(event) {
    this.selectedSeatId = event.target.value;
  }

  getShowDetails(id, timing) {
    this.selectedShowId = id;
    this.selectedShowTime = timing;
  }

  bookingTicket(selectedSeatId, ticketPrice) {
    console.log(this.selectedTheaterId, this.selectedShowId, selectedSeatId * ticketPrice, this.selectedShowTime );
    var booking = new Booking({theaterId : this.selectedTheaterId, 
                               showId : this.selectedShowId, 
                               ticketPrice : selectedSeatId * ticketPrice, 
                               seatNumber : selectedSeatId, 
                               date : this.selectedShowTime});
    this.bookingService.postBooking(booking).subscribe(
      data => {
        this.bookedId = <number>data;
        this.getAllBookings();
      }
    )
  }

  getAllBookings(){
    this.bookingService.getBookings(this.bookedId).subscribe(
      data=>{
        this.bookingDetails = data;
      }
    ) 
  }
}