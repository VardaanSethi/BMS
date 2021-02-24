export class Theater{
    Id:number;
    Name:string;
    Address:string;
    noOfScreens:number;

    constructor(theater:Theater){
        this.Id = theater.Id;
        this.Name = theater.Name;
        this.Address = theater.Address;
    }
}