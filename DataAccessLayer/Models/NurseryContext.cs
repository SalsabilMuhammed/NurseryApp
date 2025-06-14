using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class NurseryContext : DbContext
    {
        public NurseryContext(DbContextOptions<NurseryContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Nanny> Nannies { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<NurseryClass> NurseryClasses { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
       
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }
            return base.SaveChangesAsync();
        }

    }
}
