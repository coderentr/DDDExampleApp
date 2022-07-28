using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem:BaseEntity
    {
        public int Quentity { get; private set; }
        public decimal Price { get; private set; }
        public Guid ProductId { get; private set; }

        public OrderItem(int quentity, decimal price, Guid productId)
        {
            if(quentity <= 0)
            {
                throw new Exception("Order Item Quentity can not be 0 and less than 0");
            }
            if(productId == Guid.Empty)
            {
                throw new Exception("ProductId cannot be null");
            }
            Quentity = quentity;
            Price = price;
            ProductId = productId;
        }
    }
}
