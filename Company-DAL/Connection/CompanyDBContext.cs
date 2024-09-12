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

        public object AsNoTracking()
        {
            throw new NotImplementedException();
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                         .Property(e => e.Gender)
                         .HasConversion(
                         (Gender) => Gender.ToString(), (GenderString) => (Gender)Enum.Parse(typeof(Gender), GenderString,true)
                         );
        }
    }
}
