
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
        bool status = false;

        public Employee Get(string email, string password)
        {
            var get = myContext.Employees.Find(email, password);
            return get;
        }

    }
}
