using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Dto
{
    public class UserDto
    {
        public int userId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string firstName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string lastName { get; set; }
        [Required]
        [RegularExpression(@"\b\d{3}[-]?\d{3}[-]?\d{4}|\d{2}[-]?\d{3}[-]?\d{4}|\d{1}[-]?\d{3}[-]?\d{6}|\d{1}[-]?\d{3}[-]?\d{2}[-]?\d{2}[-]?\d{2}|\*{1}?\d{2,5}\b")]

        public string phone { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(15)]
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
