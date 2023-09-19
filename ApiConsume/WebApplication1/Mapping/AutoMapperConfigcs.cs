using AutoMapper;
using DtoLayer.Dtos.RoomDto;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Mapping
{
    public class AutoMapperConfigcs:Profile
    {
        public AutoMapperConfigcs()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();//Tersine Mapleme Yapma

        }
    }
}
