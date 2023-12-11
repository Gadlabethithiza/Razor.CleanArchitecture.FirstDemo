﻿namespace Razor.CleanArchitecture.Application;

public record GetPlayersWithPaginationQuery : IRequest<PaginatedResult<GetPlayersWithPaginationDto>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
 
    public GetPlayersWithPaginationQuery() { }
 
    public GetPlayersWithPaginationQuery(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    } 
}
 
internal class GetPlayersWithPaginationQueryHandler : IRequestHandler<GetPlayersWithPaginationQuery, PaginatedResult<GetPlayersWithPaginationDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
 
    public GetPlayersWithPaginationQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
 
    public async Task<PaginatedResult<GetPlayersWithPaginationDto>> Handle(GetPlayersWithPaginationQuery query, CancellationToken cancellationToken)
    {
        return await _unitOfWork.Repository<Player>().Entities
               .OrderBy(x => x.Name) 
               .ProjectTo<GetPlayersWithPaginationDto>(_mapper.ConfigurationProvider)
               .ToPaginatedListAsync(query.PageNumber, query.PageSize, cancellationToken);
    }

    public static async Task<PaginatedResult<T>> ToPaginatedListAsync<T>(this IQueryable<T> source, int pageNumber, int pageSize, CancellationToken cancellationToken) where T : class
    {
        pageNumber = pageNumber == 0 ? 1 : pageNumber;
        pageSize = pageSize == 0 ? 10 : pageSize;
        int count = await source.CountAsync();
        pageNumber = pageNumber <= 0 ? 1 : pageNumber;
        List<T> items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync(cancellationToken);
        return PaginatedResult<T>.Create(items, count, pageNumber, pageSize);
    }

}