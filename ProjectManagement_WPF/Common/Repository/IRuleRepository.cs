using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IRuleRepository
    {
        List<Rule> Get();
        List<Rule> GetSearch(string Values);
        Rule Get(int id);
        bool Insert(RuleVM RuleVM);
        bool Update(int id, RuleVM ruleVM);
        bool Delete(int id);
    }
}
