using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Abstract
{
    public interface IAdministratorRepository
    {
        List<Administator> GetAdministators();

        Administator GetAdministatorById(int id);

        Administator GetAdministatorByEmail(string e_mail);

        Administator CreateAdministrator(Administator administator);

        Administator UpdateAdministrator(Administator administator);
        
        void DeleteAdministrator(int id);

    }
}
