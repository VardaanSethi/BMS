using AutoMapper;
using BookMyShow.Models.ViewModel;
using BookMyShowWebAPI.Models;
using DataModel = BookMyShowWebAPI.Data;

namespace BookMyShow
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Show, DataModel.Show>();
            CreateMap<DataModel.Show, Show>();

            CreateMap<Show, ShowView>();
            CreateMap<ShowView, Show>();

            CreateMap<Booking, DataModel.Booking>();
            CreateMap<DataModel.Booking, Booking>();

            CreateMap<Screen, DataModel.Screen>();
            CreateMap<DataModel.Screen, Screen>();

            CreateMap<Movie, DataModel.Movie>();
            CreateMap<DataModel.Movie, Movie>();

            CreateMap<Theater, DataModel.Theater>();
            CreateMap<DataModel.Theater, Theater>();
        }
    }
}