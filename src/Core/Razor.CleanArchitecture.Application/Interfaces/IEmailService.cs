using Razor.CleanArchitecture.Application.DTOs.Email;
namespace Razor.CleanArchitecture.Application.Interfaces;

public interface IEmailService
{
    Task SendAsync(EmailRequestDto request);
}
