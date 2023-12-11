namespace Razor.CleanArchitecture.Application;

public class PlayerCreatedEvent : BaseEvent
{
    public Player Player { get; }
 
    public PlayerCreatedEvent(Player player)
    {
        Player = player;
    }
}