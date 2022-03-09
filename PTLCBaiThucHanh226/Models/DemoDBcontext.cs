using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTLCBaiThucHanh226.Models
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }

        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Demo>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<Demo>()
                .Property(e => e.StudentName)
                .IsFixedLength();
        }
    }
}
