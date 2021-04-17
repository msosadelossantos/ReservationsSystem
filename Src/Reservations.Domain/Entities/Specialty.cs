using System.Collections.Generic;


namespace Reservations.Domain.Entities
{
   public class Specialty
    {
        public string SpecialtyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
  
        public virtual IEnumerable<SpecialistSpecialty> SpecialistSpecialties { get; set; }
    }
}
