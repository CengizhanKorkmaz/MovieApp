using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.ViewComponents.UserLayoutWebUIComponents;

public class _UserLayoutWebUIRegisterModalComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}