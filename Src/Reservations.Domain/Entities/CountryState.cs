using System.Collections.Generic;


namespace Reservations.Domain.Entities
{
    public class CountryState
    {
        public string CountryStateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual IEnumerable<Specialist> Specialists { get; set; }
        
        public virtual IEnumerable<Client> Clients { get; set; }
       
        public virtual IEnumerable<Operator> Operators { get; set; }
       
    }
}
