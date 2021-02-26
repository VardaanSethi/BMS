using AutoMapper;
using BookMyShowWebAPI.Data;
using BookMyShowWebAPI.Models;

namespace BookMyShow
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ShowModel, ShowDataModel>();
            CreateMap<ShowDataModel, ShowModel>();

            CreateMap<BookingModel, BookingDataModel>();
            CreateMap<BookingDataModel, BookingModel>();

            CreateMap<ScreenModel, ScreenDataModel>();
            CreateMap<ScreenDataModel, ScreenModel>();

            CreateMap<MovieModel, MovieDataModel>();
            CreateMap<MovieDataModel, MovieModel>();

            CreateMap<TheaterModel, TheaterDataModel>();
            CreateMap<TheaterDataModel, TheaterModel>();
        }
    }
}