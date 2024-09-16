using Company_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_DAL.Connection
{
    public class CompanyDBContext:DbContext
    {
        #region Constructor
        public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options) { }
        #endregion


        #region Property
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                        .HasMany(d => d.Employess)
                        .WithOne(e => e.Department)
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
