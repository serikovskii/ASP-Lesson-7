namespace WebApplication10.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication10.Models;

    public class JobsContext : DbContext
    {
        public JobsContext()
            : base("name=JobsContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }

}