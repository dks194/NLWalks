﻿using AutoMapper;

namespace NLWalks.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                //.ForMember(dest=>dest.Id,options=>options.MapFrom(src=>src.Id))
                .ReverseMap();
        }
    }
}
