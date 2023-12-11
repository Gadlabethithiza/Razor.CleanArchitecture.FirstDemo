using Razor.CleanArchitecture.Domain.Common;
using Razor.CleanArchitecture.Domain.Entities;

namespace Razor.CleanArchitecture.Application.Features.Players.Commands.DeletePlayer
{
    public class PlayerDeletedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerDeletedEvent(Player player)
        {
            Player = player;
        }
    }
}