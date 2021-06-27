using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);

        void SaveCustomer(int id, Customer customer);
    }
}
