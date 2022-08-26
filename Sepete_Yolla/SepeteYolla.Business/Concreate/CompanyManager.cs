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
    public class CompanyManager : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        public CompanyManager()
        {
            _companyRepository = new CompanyRepository();
        }

        public Company CreateCompany(Company company)
        {
            return _companyRepository.CreateCompany(company);
        }

        public void DeleteCompany(int id)
        {
            _companyRepository.DeleteCompany(id);
        }

        public List<Company> GetCompanies()
        {
            return _companyRepository.GetCompanies();
        }

        public List<Company> GetCompaniesByBrand(string brand)
        {
            return _companyRepository.GetCompaniesByBrand(brand);
        }

        public Company GetCompanyById(int id)
        {
            return _companyRepository.GetCompanyById(id);
        }

        public Company UpdateCompany(Company company)
        {
            return _companyRepository.UpdateCompany(company);
        }
    }
}
