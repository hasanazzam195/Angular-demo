using AngularDemo.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.services
{
    public class EmployeeService:IEmployeeService
    {
        EmployeeContext context;
        public EmployeeService(EmployeeContext employeeContext)
        {
            context = employeeContext;
        }
        public void Insert(Employee employee)
        {
            context.empContext.Add(employee);
            context.SaveChanges();
        }

        public List<Employee> LoadByName(string name)
        {
            List<Employee> li = context.empContext.Where(x => x.Name == name).ToList();
            return li;
        }
    }
}
