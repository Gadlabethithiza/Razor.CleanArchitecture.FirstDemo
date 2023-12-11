using Razor.CleanArchitecture.Application.Interfaces.Repositories;
using Razor.CleanArchitecture.Domain.Common;
using Razor.CleanArchitecture.Domain.Entities;
using Razor.CleanArchitecture.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Razor.CleanArchitecture.Application.Common.Interfaces.Repositories;

namespace Razor.CleanArchitecture.Persistence.Repositories;

public class PlayerRepository : IPlayerRepository
{
    private readonly IGenericRepository<Player> _repository;
 
    public PlayerRepository(IGenericRepository<Player> repository) 
    {
        _repository = repository;
    }
 
    public async Task<List<Player>> GetPlayersByClubAsync(int clubId)
    {
        return await _repository.Entities.Where(x => x.ClubId == clubId).ToListAsync();
    }
}
