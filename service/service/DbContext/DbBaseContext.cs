using Microsoft.EntityFrameworkCore;
using service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace service
{
    public class DbBaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KODEVALBINJ\EAUDIT;Database=EmployeeDB;User Id=sa;Password=Password!;");
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
