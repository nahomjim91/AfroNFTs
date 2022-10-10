using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfroNFTs.Models
{
    internal abstract class User
    {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public decimal balance;

    }
}
