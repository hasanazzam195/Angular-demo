using AngularDemo.data;
using AngularDemo.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private  ICountryService countryService;
        private  IEmployeeService employeeService;

        public EmployeeController(ICountryService _countryService,IEmployeeService _employeeService)
        {
            countryService = _countryService;
            employeeService = _employeeService;
        }
        [HttpGet]
        [Route("loadCountry")]
        public List<Country> loadCountry()
        {
            List<Country> li = countryService.LoadAll();
            return li;
        }

        [HttpPost]
        public void insert(Employee employee)
        {
            employeeService.Insert(employee);
        }
        [HttpGet]
        [Route("LoadByName/{Name}")]
        public List<Employee> Search(string name)
        {
            List<Employee> li = employeeService.LoadByName(name);
            return li;
        }

    }
}
