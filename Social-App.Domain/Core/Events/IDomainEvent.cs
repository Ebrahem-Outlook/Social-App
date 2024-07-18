using MediatR;
using Microsoft.VisualBasic;

namespace Social_App.Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid EventId { get; }
    DateTime OccerOn { get; }
}
