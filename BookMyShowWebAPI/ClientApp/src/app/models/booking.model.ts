
export class Booking {
    theaterId:number;
    showId:number;
    ticketPrice:number;
    seatNumber:number;
    date:Date;

    constructor(booking:Booking){
        this.theaterId = booking.theaterId;
        this.showId = booking.showId;
        this.ticketPrice = booking.ticketPrice;
        this.seatNumber = booking.seatNumber;
        this.date = booking.date;
    }
}