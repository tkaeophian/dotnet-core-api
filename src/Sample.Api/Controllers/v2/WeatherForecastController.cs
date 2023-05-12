using Microsoft.AspNetCore.Mvc;
using Sample.Api.Models;

namespace Sample.Api.Controllers.v2;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class WeatherForecastController : ApiControllerBase
{
    [MapToApiVersion("2.0")]
    [HttpGet]
    public string Get() => ".Net Core Web API Version 2";
}