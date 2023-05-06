using Microsoft.AspNetCore.Mvc;
using Sample.Api.Models;

namespace Sample.Api.Controllers.v1;

[ApiController]
[Route("api/[controller]")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class WeatherForecastController : ControllerBase
{
    [MapToApiVersion("1.0")]
    [HttpGet]
    public string Get() => ".Net Core Web API Version 1";
}