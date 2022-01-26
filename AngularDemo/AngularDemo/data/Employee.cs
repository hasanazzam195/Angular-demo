using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.data
{
    [Table("Employees")]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
        [ForeignKey("country")]
        public int Country_id { get; set; }
        public Country country { get; set; }

    }
}
