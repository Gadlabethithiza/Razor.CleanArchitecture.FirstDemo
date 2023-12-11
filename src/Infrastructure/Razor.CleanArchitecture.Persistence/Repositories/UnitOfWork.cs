﻿using Razor.CleanArchitecture..Application.Interfaces.Repositories;
using Razor.CleanArchitecture..Domain.Common;
using Razor.CleanArchitecture..Domain.Common.Interfaces;
using Razor.CleanArchitecture..Persistence.Contexts;

using System.Collections;

namespace Razor.CleanArchitecture.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;
    private Hashtable _repositories;
    private bool disposed;
 
    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }
 
    public IGenericRepository<T> Repository<T>() where T : BaseAuditableEntity
    {
        if (_repositories == null)
            _repositories = new Hashtable();
 
        var type = typeof(T).Name;
 
        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);
 
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _dbContext);
 
            _repositories.Add(type, repositoryInstance);
        }
 
        return (IGenericRepository<T>) _repositories[type];
    }

    public Task Rollback()
    {
        _dbContext.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
        return Task.CompletedTask;
    }
 
    public async Task<int> Save(CancellationToken cancellationToken)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    } 
}
