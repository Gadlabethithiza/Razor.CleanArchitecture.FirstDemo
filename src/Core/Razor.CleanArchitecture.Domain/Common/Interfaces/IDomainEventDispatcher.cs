namespace Razor.CleanArchitecture.Domain;

public interface IDomainEventDispatcher
{
    Task DispatchAndClearEvents(IEnumerable<BaseEntity> entitiesWithEvents);
}
