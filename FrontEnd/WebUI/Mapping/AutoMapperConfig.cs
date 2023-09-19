using AutoMapper;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Dtos.AboutDto;
using WebUI.Dtos.BookingDto;
using WebUI.Dtos.LoginUserDto;
using WebUI.Dtos.RegisterDto;
using WebUI.Dtos.ServicesDto;
using WebUI.Dtos.StaffDto;
using WebUI.Dtos.SubscribeDto;

namespace WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Services>().ReverseMap();
            CreateMap<UpdateServiceDto, Services>().ReverseMap();
            CreateMap<CreateServiceDto, Services>().ReverseMap();
            CreateMap<CreateNewUserDto, AddUser>().ReverseMap();
            CreateMap<LoginUserDto, AddUser>().ReverseMap();
            CreateMap<ResultAboutDto, AboutUs>().ReverseMap();
            CreateMap<UpdateAboutDto, AboutUs>().ReverseMap();
            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<CreateBookingDto,Booking >().ReverseMap();
            CreateMap<ResultBookingDto,Booking>().ReverseMap();
        }
    }
}
