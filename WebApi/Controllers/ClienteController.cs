using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController, Route ("api/[controller]")]
public class ClienteController : ApiControllerBase<Cliente>
{
    public ClienteController(DataContext context, ILogger<Cliente> logger) : base(context, logger)
    {
            
    }
}