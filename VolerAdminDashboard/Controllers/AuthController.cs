using Microsoft.AspNetCore.Mvc;
using VolerAdminDashboard.BussinessServices;
using VolerAdminDashboard.Models;

namespace VolerAdminDashboard.Controllers;

public class AuthController : Controller
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    public IActionResult Login() => View();
    public IActionResult Register() => View();
    public IActionResult ForgotPassword() => View();

    [HttpPost]
    public IActionResult Login(string userName, string password)
    {
        //undone
        //auth service login method
        //auth proccess
        //redirect to dashboard
        return View();
    }

    [HttpPost]
    public IActionResult Register(AppUserModel appUser)
    {
        //undone
        //auth service register method
        //auth proccess
        //redirect to login


        return RedirectToAction("Login","Auth");
    }

    [HttpPost]
    public IActionResult ForgotPassword(string eMail)
    {
        //undone
        //auth service forgotpass method
        //auth proccess
        //redirect to dashboard

        bool response = _authService.ForgotPassword(eMail);

        return View();
    }


}
