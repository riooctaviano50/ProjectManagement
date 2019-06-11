using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = DataAccess.Models.Task;

namespace DataAccess.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext") { }

        public DbSet<Status> Statuses { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Replies> Replies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
