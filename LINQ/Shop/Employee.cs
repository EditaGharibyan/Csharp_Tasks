using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_in_C_.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public int sectionId { get; set; }

        public Employee(int id, string name, decimal salary, int sectionId)
        {
            Id = id;
            Name = name;
            Salary = salary;
            this.sectionId = sectionId;
        }
    }
}
