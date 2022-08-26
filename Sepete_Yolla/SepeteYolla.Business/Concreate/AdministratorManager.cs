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
    public class AdministratorManager : IAdministratorService
    {
        private IAdministratorRepository _administratorRepository;
        public AdministratorManager()
        {
            _administratorRepository = new AdministratorRepository();
        }

        public Administator CreateAdministrator(Administator administator)
        {
            return _administratorRepository.CreateAdministrator(administator);
        }

        public void DeleteAdministrator(int id)
        {
            _administratorRepository.DeleteAdministrator(id);
        }

        public Administator GetAdministatorByEmail(string e_mail)
        {
            return _administratorRepository.GetAdministatorByEmail(e_mail);
        }

        public Administator GetAdministatorById(int id)
        {
            return _administratorRepository.GetAdministatorById(id);
        }

        public List<Administator> GetAdministators()
        {
            return _administratorRepository.GetAdministators();
        }

        public Administator UpdateAdministrator(Administator administator)
        {
            return _administratorRepository.UpdateAdministrator(administator);
        }
    }
}
