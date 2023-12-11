﻿using Razor.CleanArchitecture.Domain.Entities;
namespace Razor.CleanArchitecture.Application.Common.Interfaces.Repositories;

public interface IPlayerRepository
{
    Task<List<Player>> GetPlayersByClubAsync(int clubId);
}
