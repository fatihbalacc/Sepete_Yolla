using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SepeteYolla.DataAccess.Concreate
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer CreateCustomer(Customer customer)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Customers.Add(customer);
                sepeteYollaDbContext.SaveChanges();
                return customer;
            }
        }

        public void DeleteCustomer(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_Customer = sepeteYollaDbContext.Customers.Find(id);

                sepeteYollaDbContext.Customers.Remove(deleted_Customer);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public List<Customer> GetCustomers()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Customers.ToList();
            }
        }

        public Customer UpdateCustomer(Customer customer)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var updated_customer = sepeteYollaDbContext.Customers.FirstOrDefault(x => x.Id == customer.Id);
                updated_customer = customer;
                sepeteYollaDbContext.Customers.Update(updated_customer);
                sepeteYollaDbContext.SaveChanges();
                return updated_customer;
            }   // BURAYI KONTROL ET 
        }
    }
}
