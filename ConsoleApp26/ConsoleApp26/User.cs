using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp26
{
    class User
    {
        public string Username { get; set; }
        public string Parol { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public User(string username,string parol,string firstname,string lastname)
        {
            Username = username;
            Parol = parol;
            Firstname = firstname;
            Lastname = Lastname;
        }
    }
    
}
