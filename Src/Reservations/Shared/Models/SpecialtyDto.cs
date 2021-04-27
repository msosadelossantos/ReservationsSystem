using System.Collections.Generic;


namespace Reservations.Shared.Models
{
   public class SpecialtyDto
    {
        public string SpecialtyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
  
        public virtual IEnumerable<SpecialistSpecialtyDto> SpecialistSpecialties { get; set; }
    }
}
