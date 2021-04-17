

namespace Reservations.Domain.Entities
{
    public class SpecialistSpecialty
    {
        public string SpecialistSpecialtyId { get; set; }

        public string SpecialtyId { get; set; }
        public virtual Specialty Specialty { get; set; }

        public string SpecialistId { get; set; }

        public virtual Specialist Specialist { get; set; }
    }
}
