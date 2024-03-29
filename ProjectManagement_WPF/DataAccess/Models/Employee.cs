﻿using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Employee")]
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int User_Id { get; set; }

        [ForeignKey("Rule")]
        public int Rules_Id { get; set; }
        public Rule Rule { get; set; }

        public Employee() { }

        public Employee(EmployeeVM employeeVM)
        {
            this.Name = employeeVM.Name;
            this.Email = employeeVM.Email;
            this.Password = employeeVM.Password;
            this.User_Id = employeeVM.User_Id;
        }

        public void Update(int id, EmployeeVM employeeVM)
        {
            this.Id = id;
            this.Name = employeeVM.Name;
            this.Email = employeeVM.Email;
            this.Password = employeeVM.Password;
            this.User_Id = employeeVM.User_Id;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
 
    }
}
