using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_in_C_.Models
{
    class Marketing
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Marketing(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
