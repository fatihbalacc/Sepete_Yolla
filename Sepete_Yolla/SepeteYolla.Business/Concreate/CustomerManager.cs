using SepeteYolla.Business.Abstract;
using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.DataAccess.Concreate;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Concreate
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerRepository _customerRepository;
        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }

        public Customer CreateCustomer(Customer customer)
        {
            return _customerRepository.CreateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}
