using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        Customer CreateCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer);

        void DeleteCustomer(int id);
    }
}
