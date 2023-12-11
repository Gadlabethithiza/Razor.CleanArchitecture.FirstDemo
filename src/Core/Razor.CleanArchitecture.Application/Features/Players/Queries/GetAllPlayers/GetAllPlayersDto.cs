﻿using Razor.CleanArchitecture.Application.Common.Mappings;
using Razor.CleanArchitecture.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Razor.CleanArchitecture.Application.Features.Players.Queries.GetPlayersWithPagination
{
    public class GetAllPlayersDto : IMapFrom<Player>
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int ShirtNo { get; init; }
        public int HeightInCm { get; init; }
        public string FacebookUrl { get; init; }
        public string TwitterUrl { get; init; }
        public string InstagramUrl { get; init; }
        public int DisplayOrder { get; init; }
    }
}
