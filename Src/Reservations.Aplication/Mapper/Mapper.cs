using Reservations.Shared.Models;
using Reservations.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservations.Aplication.Mapper
{
    public class Mapping : AutoMapper.Profile
    {
        public Mapping()
        {

            CreateMap<ClientDto, Domain.Entities.Client>().ReverseMap();

            CreateMap<CountryDto, Country>().ReverseMap();

            CreateMap<CountryStateDto, CountryState>().ReverseMap();

            CreateMap<OperatorDto, Operator>().ReverseMap();

            CreateMap<PersonDto, Person>().ReverseMap();

            CreateMap<SpecialistDto, Specialist>().ReverseMap();

            CreateMap<SpecialistSpecialtyDto, SpecialistSpecialty>().ReverseMap();
            CreateMap<SpecialtyDto, Specialty>().ReverseMap();

            CreateMap<UserDto, User>().ReverseMap();


        }

    }
}
