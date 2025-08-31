using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.ViewComponents.UserLayoutWebUIComponents;

public class _UserLayoutWebUINavbarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}