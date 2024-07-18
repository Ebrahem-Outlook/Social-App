namespace Social_App.Domain.Core.BaseType;

public abstract class AggregateRoot
{
    protected AggregateRoot(Guid id) : base(id) { }

    protected AggregateRoot() : base() { }

    private readonly List<IDomainEvent> domainEvent = new List<IDomainEvent>();

    public IReadOnlyCollection<IDomainEvent> 
}
