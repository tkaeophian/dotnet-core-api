using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Sample.Api.Controllers;

public class MetaController : ApiControllerBase
{
    [HttpGet("/info")]
    public ActionResult<string> Info()
    {
        var assembly = typeof(Program).Assembly;

        var creationDate = System.IO.File.GetCreationTime(assembly.Location);
        var version = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;

        return Ok($"Version: {version}, Last Updated: {creationDate}");
    }
}