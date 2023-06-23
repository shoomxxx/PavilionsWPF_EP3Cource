using PavilionsWPF.data.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavilionsWPF.data.Repository
{
    public class EfUser
    {
        public employers EmployeeCheck(string login, string password) //Проверка пользователя на существование
        {
            try
            {
                using (db_PavilionsEntities db = new db_PavilionsEntities())
                {
                    return db.employers.FirstOrDefault(x => x.login.Contains(login) && x.password == password);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
