using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa
{
    public class User
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

        public User(int id, string name, string email, string password, int phone, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
        }

        public User() { }
    }
}
