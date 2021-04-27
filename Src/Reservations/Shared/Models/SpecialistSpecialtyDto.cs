

namespace Reservations.Shared.Models
{
    public class SpecialistSpecialtyDto
    {
        public string SpecialistSpecialtyId { get; set; }

        public string SpecialtyId { get; set; }
        public virtual SpecialtyDto Specialty { get; set; }

        public string SpecialistId { get; set; }

        public virtual SpecialistDto Specialist { get; set; }
    }
}
