using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class OrderDetail
    {
        public int orderDetailId { get; set; }
        public int orderId { get; set; }
        public int pieId { get; set; }
        public int amount { get; set; }
        public decimal price { get; set; }
        public Pie Pie { get; set; }
        public Order Order { get; set; }
    }
}
