export class Movie {
    Id: number;
    Title: string;
    Description: string;
    Language: string;

    constructor(movie:Movie){
        this.Id = movie.Id;
        this.Title = movie.Title;
        this.Description = movie.Description;
        this.Language = movie.Language;
    }
}