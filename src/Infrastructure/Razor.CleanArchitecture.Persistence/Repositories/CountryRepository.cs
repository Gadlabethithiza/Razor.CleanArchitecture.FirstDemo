using Razor.CleanArchitecture.Application.Interfaces.Repositories;
using Razor.CleanArchitecture.Domain.Entities;
using Razor.CleanArchitecture.Persistence.Contexts;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razor.CleanArchitecture.Persistence.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IGenericRepository<Country> _repository;

        public CountryRepository(IGenericRepository<Country> repository) 
        {
            _repository = repository;
        } 
    }
}