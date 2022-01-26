using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.data
{
    public class EmployeeContext:DbContext
    {
        private  IConfiguration configuration;

        public EmployeeContext()
        {

        }
        public EmployeeContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Employee> empContext { get; set; }
        public DbSet<Country> countryContext { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("HRConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
