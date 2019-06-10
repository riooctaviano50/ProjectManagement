
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
    public class EmployeeRepository : IEmployeeRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;
        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
                var reuslt = myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> Get()
        {
            var get = myContext.Employees.Include("Employee").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            throw new NotImplementedException();
        }

        bool IEmployeeRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
