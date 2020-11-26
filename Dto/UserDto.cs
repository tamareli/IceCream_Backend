using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class UserDto
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }

        public UserDto()
        {

        }
        public UserDto(Client c)
        {
            userId = c.clientId;
            firstName = c.firstName;
            lastName = c.lastName;
            phone = c.phone;
            address = c.address;
            email = c.email;
            password = c.password;
            active = c.active;
            createDate = c.createDate;
            updateDate = c.updateDate;
        }
        public static Client ToDal(UserDto user)
        {
            return new Client
            {
                firstName = user.firstName,
                lastName = user.lastName,
                phone = user.phone,
                address = user.address,
                email = user.email,
                active = true,
                createDate= DateTime.Now,
                updateDate= DateTime.Now,
                password = user.password,
            };
        }
    }
}
