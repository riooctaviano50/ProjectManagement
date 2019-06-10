using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Projects")]
    public class Project : BaseModel
    {
        public string Name { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectDeadline { get; set; }
        public string ProjectDetails { get; set; }

        [ForeignKey("Status")]
        public int Status_Id { get; set; }
        public Status Status { get; set; }

        public Project() { }

        public Project(ProjectVM projectVM)
        {
            this.Name = projectVM.Name;
            this.ProjectStart = projectVM.ProjectStart;
            this.ProjectDeadline = projectVM.ProjectDeadline;
            this.ProjectDetails = projectVM.ProjectDetails;
            this.Status_Id = projectVM.Status_Id;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, ProjectVM projectVM)
        {
            this.Id = projectVM.Id;
            this.Name = projectVM.Name;
            this.ProjectStart = projectVM.ProjectStart;
            this.ProjectDeadline = projectVM.ProjectDeadline;
            this.ProjectDetails = projectVM.ProjectDetails;
            this.Status_Id = projectVM.Status_Id;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
