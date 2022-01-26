using AngularDemo.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.services
{
    public class CountryService : ICountryService
    {
        EmployeeContext context;
        public CountryService(EmployeeContext employeeContext)
        {
            context = employeeContext;
        }
        public List<Country> LoadAll()
        {
            List <Country> licountry= context.countryContext.ToList();
            return licountry;
        }
    }
}
