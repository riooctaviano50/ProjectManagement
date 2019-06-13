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
    [Table("TB_T_ProjectMember")]
    public class ProjectMember : BaseModel
    {
        public int User_Id { get; set; }

        [ForeignKey("Rule")]
        public int Rules_Id { get; set; }
        public Rule Rule { get; set; }

        [ForeignKey("Project")]
        public int Project_Id { get; set; }
        public Project Project { get; set; }


        public ProjectMember(ProjectMemberVM projectMemberVM)
        {
            this.Id = projectMemberVM.Id;
            this.User_Id = projectMemberVM.User_Id;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public ProjectMember() { }

        public void Update(ProjectMemberVM projectMemberVM)
        {
            this.Id = projectMemberVM.Id;
            this.User_Id = projectMemberVM.User_Id;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
