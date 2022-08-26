using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetCompanies();

        Company GetCompanyById(int id);

        List<Company> GetCompaniesByBrand(string brand);

        Company CreateCompany(Company company);

        Company UpdateCompany(Company company);

        void DeleteCompany(int id);
    }
}
