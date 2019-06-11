using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ProjectMemberVM
    {
        public int Id { get; set; }
        public int Project_Id { get; set; }
        public int Role_Id { get; set; }
        public int User_Id { get; set; }

        public ProjectMemberVM(int Id, int Project_Id, int Role_Id, int User_Id)
        {
            this.Id = Id;
            this.Project_Id = Project_Id;
            this.Role_Id = Role_Id;
            this.User_Id = User_Id;
        }
        public ProjectMemberVM() { }
        public void Update(int Id, int Project_Id, int Role_Id, int User_Id)
        {
            this.Id = Id;
            this.Project_Id = Project_Id;
            this.Role_Id = Role_Id;
            this.User_Id = User_Id;
        }
    }
}
