using AngularDemo.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.services
{
    public interface IEmployeeService
    {
        void Insert(Employee employee);

        List<Employee> LoadByName(string name);
    }
}
