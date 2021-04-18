using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Domain.Entities
{
    public class User
    {
        public string UserId { get; set; } 
        public string UserCode { get; set; }
        public string PassWord { get; set; }

        
        public virtual Client Client { get; set; }
        
        public virtual Specialist Specialist { get; set; }
       
        public virtual Operator Operator { get; set; }
    }
}
