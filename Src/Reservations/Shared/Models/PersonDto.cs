using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Shared.Models
{
    public class PersonDto
    {

        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Surname { get; set; }
        public string Surname2 { get; set; }
        public string Document { get; set; }
        public string TaxId { get; set; }
        public DateTime BirthDate { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNumber { get; set; }
        public string AddressCountryStateId { get; set; }
        public virtual CountryStateDto AddressCountryState { get; set; }
        public string AddressLocality { get; set; }
        public string AddressCP { get; set; }
        public string AddressCountryId { get; set; }
        public virtual CountryDto AddressCountry { get; set; }
        public string BirthCountryId { get; set; }
        public virtual CountryDto BirthCountry { get; set; }
        public string UserId { get; set; }
        public virtual UserDto User { get; set; }

    }
}
