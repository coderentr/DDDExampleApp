using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Events
{
    /// <summary>
    /// The event that will let you know that the order has started.
    /// It use MediatR pattern
    /// </summary>
    public class OrderStartedDomainEvent : INotification
    {
        public string UserName { get; set; }
        // This order started.
        public AggregateModels.OrderModels.Order Order { get; set; }

        public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
        {
            UserName = userName;
            Order = order;
        }
    }
}
