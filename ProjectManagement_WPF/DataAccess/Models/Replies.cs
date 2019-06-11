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
    [Table("TB_M_Replies")]
    public class Replies : BaseModel
    {
        public string Message { get; set; }
        public int Reply_From { get; set; }
        
        [ForeignKey("Ticket")]
        public int Ticket_Id { get; set; }
        public Ticket Ticket { get; set; }

        public Replies() { }
        public Replies(RepliesVM repliesVM)
        {
            this.Message = repliesVM.Message;
            this.Reply_From = repliesVM.Reply_From;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Update(int id, RepliesVM repliesVM)
        {
            this.Id = id;
            this.Message = repliesVM.Message;
            this.Reply_From = repliesVM.Reply_From;
            this.Ticket_Id = repliesVM.Ticket_Id;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
