using Microsoft.AspNetCore.Mvc;

namespace VolerAdminDashboard.Controllers;

public class AuthController : Controller
{
    public IActionResult Login() => View();
    public IActionResult Register() => View();
    public IActionResult ForgotPassword() => View();
}
