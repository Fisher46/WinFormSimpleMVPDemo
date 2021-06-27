using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(string fullname, string address, string email)
        {
            Fullname = fullname;
            Address = address;
            Email = email;
        }

        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
