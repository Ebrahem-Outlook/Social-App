namespace Social_App.Domain.Core.Events;

public abstract class DomainEvent : IDomainEvent
{
    protected DomainEvent()
    {
        EventId = Guid.NewGuid();
        OccerOn = DateTime.UtcNow;
    }

    public Guid EventId { get; }

    public DateTime OccerOn { get; }
}
