using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    interface IEmployeeRepository
    {
        List<Employee> Get();
        List<Employee> GetSearch(String values);
        Employee Get(int id);
        bool Insert(EmployeeVM employeeVM);
        bool Update(int id, EmployeeVM employeeVM);
        bool Delete(int id);
    }
}
