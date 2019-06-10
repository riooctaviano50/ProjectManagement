using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeVM
    {
        public EmployeeVM(string name, string email, string password, int user_id, int rules_id)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.User_Id = user_id;
            this.Rules_Id = rules_id;
        }

        public EmployeeVM() { }

        public void Update(int id, string name, string email, string password, int user_id, int rules_id)
        {
            this.Rules_Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.User_Id = user_id;
            this.Rules_Id = rules_id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int User_Id { get; set; }
        public int Rules_Id { get; set; }
    }
}
