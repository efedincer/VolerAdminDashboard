using Microsoft.AspNetCore.Mvc;

namespace VolerAdminDashboard.Controllers;

public class ErrorController : Controller
{
    [Route("Error/403")]
    public IActionResult Error403() => View();

    [Route("Error/404")]
    public IActionResult Error404() => View();

    [Route("Error/500")]
    public IActionResult Error500() => View();

}
