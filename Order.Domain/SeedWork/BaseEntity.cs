using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.SeedWork
{
    /// <summary>
    /// Base Entity
    /// </summary>
    public abstract  class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        public DateTime CreatedDate { get; set; } =DateTime.Now;
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;

        private ICollection<INotification> domainEvents;
        public ICollection<INotification> DomainEvents=>domainEvents;

        public void AddDomainEvents(INotification notification)
        {
            domainEvents ??= new List<INotification>();
            domainEvents.Add(notification);
        }

         
    }
}
