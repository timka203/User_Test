namespace ASP_exam
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_model : DbContext
    {
        public DB_model()
            : base("name=DB_model1")
        {
        }

        public virtual DbSet<Test_info> Test_info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
