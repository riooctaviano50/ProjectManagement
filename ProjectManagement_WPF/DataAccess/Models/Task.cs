using Core.Base;
using System;
using System.Collections.Generic;
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

        [ForeignKey("Status")]
        public int Status_Id { get; set; }
        public Status Status { get; set; }

        [ForeignKey("Project")]
        public int Project_Id { get; set; }
        public Project Project { get; set; }
    }
}
