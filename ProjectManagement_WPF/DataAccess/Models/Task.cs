using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_Tasks")]
    public class Task : BaseModel
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public int AssignBy { get; set; }
        public int AssignTo { get; set; }

        [ForeignKey("Status")]
        public int Status_Id { get; set; }
        public Status Status { get; set; }



        [ForeignKey("Project")]
        public int Project_Id { get; set; }
        public Project Project { get; set; }

        public Task() { }

        public Task(TaskVM taskVM)
        {
            this.Description = taskVM.Description;
            this.StartDate = taskVM.StartDate;
            this.DueDate = taskVM.DueDate;
            this.Priority = taskVM.Priority;
            this.AssignBy = taskVM.AssignBy;
            this.AssignTo = taskVM.AssignTo;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, TaskVM taskVM)
        {
            this.Id = id;
            this.Description = taskVM.Description;
            this.StartDate = taskVM.StartDate;
            this.DueDate = taskVM.DueDate;
            this.Priority = taskVM.Priority;
            this.AssignBy = taskVM.AssignBy;
            this.AssignTo = taskVM.AssignTo;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }

    }
}
