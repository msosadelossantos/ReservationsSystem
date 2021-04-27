using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Shared.Models
{
    public class RegisterDto
    {
        public RegisterDto()
        {
            Client = new ClientDto();
            User = new UserDto();
        }

        public ClientDto Client { get; set; }
        public UserDto User { get; set; }

    }
}
