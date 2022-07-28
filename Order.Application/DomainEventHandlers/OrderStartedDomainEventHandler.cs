using MediatR;
using Order.Application.Repositories;
using Order.Domain.AggregateModels.UserModels;
using Order.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.DomainEventHandlers
{
    public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IUserRepository _userRepository;

        public OrderStartedDomainEventHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //When order started run this handle.
        public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            if (notification.Order.UserName == string.Empty)
            {
                //We can create user.
                var user = new User(notification.UserName);
                // _userRepository.Add(user);  //Create user and get new id
                
                //set orders user id
            }
            return Task.CompletedTask;
        }
    }
}
