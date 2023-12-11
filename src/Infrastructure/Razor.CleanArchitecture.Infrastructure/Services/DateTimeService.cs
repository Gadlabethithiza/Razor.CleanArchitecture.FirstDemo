using Razor.CleanArchitecture.Application.Interfaces;

namespace Razor.CleanArchitecture.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
