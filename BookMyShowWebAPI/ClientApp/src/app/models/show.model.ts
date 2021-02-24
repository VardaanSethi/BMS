export class Show {
    Id:number;
    theaterId: number;
    Timing: Date;

    constructor(show:Show){
        this.Id = show.Id;
        this.theaterId = show.theaterId;
        this.Timing = show.Timing;
    }
}