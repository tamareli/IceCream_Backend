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
        public static int Register(UserDto user)
        {
            Client u = UserDto.ToDal(user);
            return UserDal.Register(u);
        }
        public static int AddGuestUser(UserDto user)
        {
            Client u = UserDto.ToDal(user);
            return UserDal.AddGuestUser(u);
        }
        public static UserDto ValidateUser(string email,string password)
        {
            Client u = UserDal.ValidateUser(email, password);
            if(u != null)
               return new UserDto(u);
            return null;
        }
        public static UserDto GetUser(int id)
        {
            Client u = UserDal.GetUser(id);
            if (u != null)
                return new UserDto(u);
            return null;
        }

        public static string GetPasswordByemail(string email)
        {
            string password = UserDal.GetPasswordByemail(email);
            return password;
        }

    }
}
