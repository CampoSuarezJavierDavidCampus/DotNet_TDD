using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace API.Controllers;

[Route("api/[controller]")]
[ExcludeFromCodeCoverage]
[ApiController]
public abstract class ApiBaseController:ControllerBase{}
