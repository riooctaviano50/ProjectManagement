
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
            var get = myContext.Employees.Find(id);
            return get;
        }

        public List<Employee> GetSearch(string values)
        {
            var get = myContext.Employees.Where
            (x => (x.Name.Contains(values) ||
            x.Id.ToString().Contains(values)) &&
            x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            var push = new Employee(employeeVM);
            myContext.Employees.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                return status;
            }
            return status;
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Update(id, employeeVM);
                myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
                var result = myContext.SaveChanges();
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
