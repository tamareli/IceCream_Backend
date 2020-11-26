using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bl
{
    public class UserBl
    {
        public static bool Register(UserDto user)
        {
            Client u = UserDto.ToDal(user);
            return UserDal.Register(u);
        }
    }
}
