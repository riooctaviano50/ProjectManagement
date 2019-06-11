using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using Common.Repository;
using Common.Repository.Application;

namespace BussinessLogic.Service.Application
{
    public class LoginService : ILoginService
    {
        ILoginRepository iLoginRepository = new LoginRepository();
        bool status = false;

        public Employee Get(string email, string password)
        {
            return iLoginRepository.Get(email, password);
        }

    }
}
