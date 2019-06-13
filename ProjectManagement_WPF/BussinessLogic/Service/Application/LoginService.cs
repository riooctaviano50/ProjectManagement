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

        public Employee GetLogin(string email, string password)
        {
            return iLoginRepository.GetLogin(email, password);
        }
    }
}

