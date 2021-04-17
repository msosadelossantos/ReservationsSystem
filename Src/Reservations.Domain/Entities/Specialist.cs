using System;
using System.Collections.Generic;


namespace Reservations.Domain.Entities
{
    public class Specialist: Person
    {
        public string SpecialistId { get; set; }
      

        public virtual IEnumerable<SpecialistSpecialty> SpecialistSpecialties { get; set; }


    }
}
