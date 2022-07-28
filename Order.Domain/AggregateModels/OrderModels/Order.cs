using Order.Domain.Events;
using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    /// <summary>
    /// The top model to manage order models.
    /// </summary>
    public class Order:BaseEntity,IAggregateRoot
    {

        public DateTime OrderDate { get; private set; }
        public string Desctiption { get; private set; }
        public string  UserName { get; private set; }
        public string OrderStatus { get; private set; }
        public Address Address { get; private set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Order(DateTime orderDate, string desctiption, string userName, string orderStatus, Address address, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
            {
                throw new Exception("Order date must be greater then now");
            }
            if (address.City == String.Empty)
            {
                throw new Exception("City can not be empty");
            }
            OrderDate = orderDate;
            Desctiption = desctiption;
            UserName = userName;
            OrderStatus = orderStatus;
            Address = address;
            OrderItems = orderItems;

            AddDomainEvents(new OrderStartedDomainEvent("",this));
        }
        public void AddOrderItem(int quentity, decimal price, Guid productId )
        {
            OrderItem item=new OrderItem(quentity, price, productId);
            OrderItems.Add(item);
        }
    }
}
