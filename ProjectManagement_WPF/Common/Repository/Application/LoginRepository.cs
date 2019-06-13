
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
    public class LoginRepository
    {
        MyContext myContext = new MyContext();

        public bool CheckLogin(string email, string password)
        {
            bool status = false;
            var get = myContext.Employees.Where(x => x.Email == email && x.Password == password && x.IsDelete == false).SingleOrDefault();

            try
            {
                if(get.Email == email && get.Password == password && get.IsDelete == false)
                {
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return status;
            }
        }

        public bool CheckAdmin(string email, string password)
        {
            bool status = false;
            var get = myContext.Employees.Where(x => x.Email == email && x.Password == password && x.IsDelete == false).SingleOrDefault();

            try
            {
                if (get.Email == email && get.Password == password && get.IsDelete == false && get.Rules_Id == 1)
                {
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return status;
            }
        }
    }
}
