using Common.Repository.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;

namespace BussinessLogic.Service.Application
{
    public class RuleService : IRuleService
    {
        IRuleRepository iRuleRepostory = new RuleRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iRuleRepostory.Delete(id);
        }

        public List<Rule> Get()
        {
            return iRuleRepostory.Get();
        }

        public Rule Get(int id)
        {
            return iRuleRepostory.Get(id);
        }

        public List<Rule> GetSearch(string Values)
        {
            return iRuleRepostory.GetSearch(Values);
        }

        public bool Insert(RuleVM ruleVM)
        {
            if (string.IsNullOrWhiteSpace(ruleVM.Name))
            {
                return status;
            }
            else
            {
                return iRuleRepostory.Insert(ruleVM);
            }
        }

        public bool Update(int id, RuleVM ruleVM)
        {
            if (string.IsNullOrWhiteSpace(ruleVM.Name))
            {
                return status;
            }
            else
            {
                return iRuleRepostory.Update(id, ruleVM);
            }
        }
    }
}
