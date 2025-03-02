using Microsoft.AspNetCore.Mvc;

namespace VolerAdminDashboard.ViewComponents;

public class Notifications : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
