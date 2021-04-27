using System.Collections.Generic;


namespace Reservations.Shared.Models
{
    public class CountryDto
    {
        public string CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual IEnumerable<SpecialistDto> Specialists { get; set; }
        public virtual IEnumerable<SpecialistDto> SpecialistNacionality { get; set; }
        public virtual IEnumerable<ClientDto> Clients { get; set; }
        public virtual IEnumerable<ClientDto> ClientsNacionality { get; set; }
        public virtual IEnumerable<OperatorDto> Operators { get; set; }
        public virtual IEnumerable<OperatorDto> OperatorsNacionality { get; set; }

    }
}
