using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class RuleVM
    {
        public RuleVM(string Name)
        {
            this.Name = Name;
        }

        public RuleVM() { }

        public void Update(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
