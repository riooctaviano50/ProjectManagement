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
    [Table("TB_M_Ticket")]
    public class Ticket : BaseModel
    {
        public string Message { get; set; }

        [ForeignKey("Employee")]
        public int From_Userid { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("ProjectMember")]
        public int Project_Id { get; set; }
        public ProjectMember ProjectMember { get; set; }

        [ForeignKey("Status")]
        public int Status_Id { get; set; }
        public Status Status { get; set; }

        public Ticket() { }
        public Ticket(TicketVM ticketVM)
        {
            this.From_Userid = ticketVM.From_UserId;
            this.Message = ticketVM.Message;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, TicketVM ticketVM)
        {
            this.Id = id;
            this.From_Userid = ticketVM.From_UserId;
            this.Message = ticketVM.Message;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
