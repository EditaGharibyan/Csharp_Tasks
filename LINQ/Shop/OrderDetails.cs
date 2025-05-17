using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_in_C_.Models
{
    class OrderDetails
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }

        public int count { get; set; }

        public OrderDetails(int id, int orderId, int productId, int count)
        {
            Id = id;
            this.orderId = orderId;
            this.productId = productId;
            this.count = count;
        }
       


    }
}
