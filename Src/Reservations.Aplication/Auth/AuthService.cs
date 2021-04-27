using System;
using System.Collections.Generic;
using System.Text;
using Reservations.Data.Context;
using Reservations.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Reservations.Domain.Entities;
using Reservations.Aplication.Mapper;
using AutoMapper;
using Reservations.Shared.Generic;
using System.Threading.Tasks;

namespace Reservations.Aplication.Auth
{
    public class AuthService : IAuthService
    {
        readonly ReservationsContext _context;
        private readonly IMapper _mapper;

        public AuthService(ReservationsContext context, IMapper mapping) {
            _context = context;
            _mapper = mapping;
        }



        public async Task<OperationResultDto<UserDto>> Login(UserDto user)
        {
            var result = _context.Users.FirstOrDefault(x => x.UserCode == user.UserCode);
            if(result.PassWord == user.PassWord)
            {
                var usr = _mapper.Map<UserDto>(result);
                return new OperationResultDto<UserDto>()
                {
                    Success = true,
                    Payload = usr

                };
            }
            else
            {
                return new OperationResultDto<UserDto>()
                {
                    Success = false,
                    Payload = null

                };
            }

        }


        public async Task<OperationResultDto<RegisterDto>> SignUp(RegisterDto reg)
        {



            return new OperationResultDto<RegisterDto>()
            {
                Success = false,
                Payload = reg

            };
        }


        private bool CreateClient(ClientDto client) {
            var clientdb = _mapper.Map<Client>(client);



            return true;
        }


        private bool CreateUser(UserDto persondto)
        {
            var userdb = _mapper.Map<User>(persondto);
                        

            return true;

        }



    }
}
