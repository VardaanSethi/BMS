
export class Booking {
    theaterId:number;
    showId:number;
    ticketPrice:number;
    seatNumber:number;
    bookingDate:Date;

    constructor( theaterId:number,showId:number,ticketPrice:number,seatNumber:number,bookingDate:Date){
        this.theaterId = theaterId;
        this.showId = showId;
        this.ticketPrice = ticketPrice;
        this.seatNumber = seatNumber;
        this.bookingDate = bookingDate;
    }
}