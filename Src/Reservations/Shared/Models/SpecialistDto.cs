using System;
using System.Collections.Generic;


namespace Reservations.Shared.Models
{
    public class SpecialistDto: PersonDto
    {
        public string SpecialistId { get; set; }
      

        public virtual IEnumerable<SpecialistSpecialtyDto> SpecialistSpecialties { get; set; }


    }
}
