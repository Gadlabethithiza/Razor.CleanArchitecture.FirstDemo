namespace Razor.CleanArchitecture.Application;

public interface IEmailService
{
    Task SendAsync(EmailRequestDto request);
}
