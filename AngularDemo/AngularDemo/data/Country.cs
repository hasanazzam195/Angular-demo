using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularDemo.data
{
    [Table("Countries")]
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }
    }
}
