using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class TaskVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public int AssignBy { get; set; }
        public int AssignTo { get; set; }
        public int Status_Id { get; set; }
        public int Project_Id { get; set; }

        public TaskVM() { }

        public TaskVM(string description, DateTime start, DateTime end, string priority,int assign_by,int assign_to, int status_id, int project_id)
        {
            this.Description = description;
            this.StartDate = start;
            this.DueDate = end;
            this.Priority = priority;
            this.AssignBy = assign_by;
            this.AssignTo = assign_to;
            this.Status_Id = status_id;
            this.Project_Id = project_id;
        }

        public void Update(int id, string description, DateTime start, DateTime end, string priority, int assign_by, int assign_to, int status_id, int project_id)
        {
            this.Id = id;
            this.Description = description;
            this.StartDate = start;
            this.DueDate = end;
            this.Priority = priority;
            this.AssignBy = assign_by;
            this.AssignTo = assign_to;
            this.Status_Id = status_id;
            this.Project_Id = project_id;
        }

    }
}
