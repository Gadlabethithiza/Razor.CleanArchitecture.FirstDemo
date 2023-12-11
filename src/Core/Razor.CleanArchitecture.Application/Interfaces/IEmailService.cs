using Razor.CleanArchitecture.Application.Email;

namespace Razor.CleanArchitecture.Application.Interfaces;

public interface IEmailService
{
    Task SendAsync(EmailRequestDto request);
}
