namespace Razor.CleanArchitecture.Application;

public interface IPlayerRepository
{
    Task<List<Player>> GetPlayersByClubAsync(int clubId);
}
