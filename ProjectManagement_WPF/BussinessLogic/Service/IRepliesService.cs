using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Service
{
    public interface IRepliesService
    {
        List<Replies> Get();
        List<Replies> GetSearch(string values);
        Replies Get(int id);
        bool Insert(RepliesVM repliesVM);
        bool Delete(int id);
    }
}
