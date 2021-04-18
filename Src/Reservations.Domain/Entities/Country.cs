using System.Collections.Generic;


namespace Reservations.Domain.Entities
{
    public class Country
    {
        public string CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual IEnumerable<Specialist> Specialists { get; set; }
        public virtual IEnumerable<Specialist> SpecialistNacionality { get; set; }
        public virtual IEnumerable<Client> Clients { get; set; }
        public virtual IEnumerable<Client> ClientsNacionality { get; set; }
        public virtual IEnumerable<Operator> Operators { get; set; }
        public virtual IEnumerable<Operator> OperatorsNacionality { get; set; }

    }
}
