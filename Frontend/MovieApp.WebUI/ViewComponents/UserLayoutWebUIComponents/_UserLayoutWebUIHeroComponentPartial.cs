using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.ViewComponents.UserLayoutWebUIComponents;

public class _UserLayoutWebUIHeroComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}