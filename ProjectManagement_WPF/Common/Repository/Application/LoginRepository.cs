
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.Context;

namespace Common.Repository.Application
{
    public class LoginRepository : ILoginRepository
    {
        MyContext myContext = new MyContext();

        public Employee GetLogin(string email, string password)
        {
            var get = myContext.Employees.Where
            (x => (x.Email.Contains(email) ||
             x.Password.Contains(password)) &&
             x.IsDelete == false).SingleOrDefault();
            return get;
        }
    }
}
