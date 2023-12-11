using Razor.CleanArchitecture.Domain.Common;
using Razor.CleanArchitecture.Domain.Entities;
namespace Razor.CleanArchitecture.Application.Features.Players.Commands.CreatePlayer;

public class PlayerCreatedEvent : BaseEvent
{
    public Player Player { get; }
 
    public PlayerCreatedEvent(Player player)
    {
        Player = player;
    }
}