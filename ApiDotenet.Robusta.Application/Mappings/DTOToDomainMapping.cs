﻿using ApiDotenet.Robusta.Application.DTOs;
using ApiDotnetRobusta.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotenet.Robusta.Application.Mappings
{
    public class DTOToDomainMapping : Profile
    {
        public DTOToDomainMapping()
        {
            CreateMap<PersonDTO, Person>();
        }
    }
}
