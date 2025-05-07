using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_in_C_.Models
{
    enum OrderStatus { Pending, OnTheWay, Deliveried, PaymentRejected };
    class Order
    {
        public int Id { get; set; }
        public int userId { get; set; }

        public OrderStatus Status { get; set; }

        public Order(int id, int userId, OrderStatus status)
        {
            Id = id;
            this.userId = userId;
            Status = status;
        }


    }
}
