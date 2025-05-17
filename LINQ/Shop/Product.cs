using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_in_C_.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int categoryId { get; set; }

        public Product(int id, string name, double price, int categoryId)
        {
            Id = id;
            Name = name;
            Price = price;
            this.categoryId = categoryId;
        }
        public override string ToString()
        {
            return $"{{Id: {Id}, Name:{Name}, Price:{Price} USD, categorry: {categoryId}}}\n";
        }
    }
}
