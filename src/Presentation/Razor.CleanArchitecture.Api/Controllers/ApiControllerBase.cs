using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace Razor.CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
       
    }
}