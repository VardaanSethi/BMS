export class Screen {
    Id:number;
    theaterId: number;
    movieId:number;
    noOfSeats:number;
    
    constructor(screen:Screen){
        this.Id = screen.Id;
        this.theaterId = screen.theaterId;
        this.noOfSeats = screen.noOfSeats;
    }
}