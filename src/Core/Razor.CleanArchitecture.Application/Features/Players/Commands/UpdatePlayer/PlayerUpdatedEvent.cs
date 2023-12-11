using Razor.CleanArchitecture.Domain.Common;
using Razor.CleanArchitecture.Domain.Entities;

namespace Razor.CleanArchitecture.Application.Features.Players.Commands.UpdatePlayer
{
    public class PlayerUpdatedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerUpdatedEvent(Player player)
        {
            Player = player;
        }
    }
}