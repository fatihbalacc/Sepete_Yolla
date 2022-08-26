using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Concreate
{
    public class CompanyRepository : ICompanyRepository
    {
        public Company CreateCompany(Company company)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Companies.Add(company);
                sepeteYollaDbContext.SaveChanges();
                return company;
            }
        }

        public void DeleteCompany(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_Company = sepeteYollaDbContext.Companies.Find(id);

                sepeteYollaDbContext.Companies.Remove(deleted_Company);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public List<Company> GetCompanies()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Companies.ToList();
            }
        }

        public List<Company> GetCompaniesByBrand(string brand)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Companies.ToList().FindAll(x => x.Brand.Contains(brand));
            }
        }

        public Company GetCompanyById(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Companies.Find(id);
            }
        }

        public Company UpdateCompany(Company company)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var updated_company = sepeteYollaDbContext.Companies.FirstOrDefault(x => x.Id == company.Id);
                updated_company = company;
                sepeteYollaDbContext.Companies.Update(updated_company);
                sepeteYollaDbContext.SaveChanges();
                return updated_company;
            }   // BURAYI KONTROL ET 
        }
    }
}
