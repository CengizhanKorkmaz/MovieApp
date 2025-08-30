using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.ViewComponents.UserLayoutWebUIComponents;

public class _UserLayoutWebUILoginModalComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}