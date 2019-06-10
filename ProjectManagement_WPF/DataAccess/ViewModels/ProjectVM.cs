using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ProjectVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectDeadline { get; set; }
        public string ProjectDetails { get; set; }
        public int Status_Id { get; set; }

        public ProjectVM() { }

        public ProjectVM(string name, DateTime start, DateTime end, string details, int status_id)
        {
            this.Name = name;
            this.ProjectStart = start;
            this.ProjectDeadline = end;
            this.ProjectDetails = details;
            this.Status_Id = status_id;
        }

        public void Update(int id, string name, DateTime start, DateTime end, string details, int status_id)
        {
            this.Id = id;
            this.Name = name;
            this.ProjectStart = start;
            this.ProjectDeadline = end;
            this.ProjectDetails = details;
            this.Status_Id = status_id;
        }
    }
}