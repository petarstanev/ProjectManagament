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
        }

        public System.Data.Entity.DbSet<Models.Member> Members { get; set; }
    }
}
