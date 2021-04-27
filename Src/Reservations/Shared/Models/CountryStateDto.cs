using System.Collections.Generic;


namespace Reservations.Shared.Models
{
    public class CountryStateDto
    {
        public string CountryStateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual IEnumerable<SpecialistDto> Specialists { get; set; }
        
        public virtual IEnumerable<ClientDto> Clients { get; set; }
       
        public virtual IEnumerable<OperatorDto> Operators { get; set; }
       
    }
}
