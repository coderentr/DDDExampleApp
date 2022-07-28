using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.UserModels
{
    public class User:BaseEntity
    {
        public string UserName { get; private set; }

        public User(string userName)
        {
            UserName = userName;
        }
    }
}
