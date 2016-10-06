namespace ClickCounter.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClickCounterContext : DbContext
    {
        public ClickCounterContext()
            : base("name=ClickCounterContext")
        {
        }

        public virtual DbSet<ClickCounterModel> ClickCounters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
