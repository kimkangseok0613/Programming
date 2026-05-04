using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class User
    {
        public string email;
        public string password;
        public string Email { get { return email; } }
        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
