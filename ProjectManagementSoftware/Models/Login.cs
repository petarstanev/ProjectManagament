namespace ProjectManagementSoftware.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Login : DbContext
    {
        public Login()
            : base("name=Login")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Login>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Member> Members { get; set; }

    }
}
