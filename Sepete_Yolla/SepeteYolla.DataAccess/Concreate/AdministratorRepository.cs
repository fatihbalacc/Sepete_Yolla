using SepeteYolla.DataAccess.Abstract;
using SepeteYolla.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepeteYolla.DataAccess.Concreate
{
    public class AdministratorRepository : IAdministratorRepository
    {
        public Administator CreateAdministrator(Administator administator)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                sepeteYollaDbContext.Administators.Add(administator);
                sepeteYollaDbContext.SaveChanges();
                return administator;
            }
        }

        public void DeleteAdministrator(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var deleted_Administrator = sepeteYollaDbContext.Administators.Find(id);
                
                sepeteYollaDbContext.Administators.Remove(deleted_Administrator);
                sepeteYollaDbContext.SaveChanges();
            }
        }

        public Administator GetAdministatorByEmail(string e_mail)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Administators.FirstOrDefault(x => x.E_mail == e_mail);
            }
        }

        public Administator GetAdministatorById(int id)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Administators.Find(id);
            }
        }

        public List<Administator> GetAdministators()
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                return sepeteYollaDbContext.Administators.ToList();
            }
        }

        public Administator UpdateAdministrator(Administator administator)
        {
            using (var sepeteYollaDbContext = new SepeteYollaDbContext())
            {
                var updated_administrator = sepeteYollaDbContext.Administators.FirstOrDefault(x => x.Id == administator.Id);
                updated_administrator = administator;
                sepeteYollaDbContext.Administators.Update(updated_administrator);
                sepeteYollaDbContext.SaveChanges();
                return updated_administrator;
            }   // BURAYI KONTROL ET 
        }
    }
}
