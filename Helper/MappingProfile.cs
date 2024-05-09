﻿using AutoMapper;
using SigmaTestTask.Domain;
using SigmaTestTask.DTOs;

namespace SigmaTestTask.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact,ContactDto>().ReverseMap();
        }
    }
}
