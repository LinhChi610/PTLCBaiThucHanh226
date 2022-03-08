using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTLCBaiThucHanh226.Models
{
    public partial class DemoDBcontext : DbContext
    {
        public DemoDBcontext()
            : base("name=DemoDBcontext")
        {
        }

        public virtual DbSet<DemoDB> DemoDBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DemoDB>()
                .Property(e => e.StudentID)
                .IsFixedLength();

            modelBuilder.Entity<DemoDB>()
                .Property(e => e.StudentName)
                .IsFixedLength();
        }
    }
}
