﻿using Reservations.Shared.Generic;
using Reservations.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Aplication.Auth
{
    public interface IAuthService
    {
        Task<OperationResultDto<UserDto>> Login(UserDto user);
        Task<OperationResultDto<RegisterDto>> SignUp(RegisterDto reg);
    }
}