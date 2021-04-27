using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Shared.Models
{
    public class UserDto
    {
        public string UserId { get; set; } 
        public string UserCode { get; set; }
        public string PassWord { get; set; }

        
        public virtual ClientDto Client { get; set; }
        
        public virtual SpecialistDto Specialist { get; set; }
       
        public virtual OperatorDto Operator { get; set; }
    }
}
