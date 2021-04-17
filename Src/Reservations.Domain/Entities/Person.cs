using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Domain.Entities
{
    public class Person
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
        public virtual CountryState AddressCountryState { get; set; }
        public string AddressLocality { get; set; }
        public string AddressCP { get; set; }
        public string AddressCountryId { get; set; }
        public virtual Country AddressCountry { get; set; }
        public string BirthCountryId { get; set; }
        public virtual Country BirthCountry { get; set; }

    }
}
