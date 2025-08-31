using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.ViewComponents.UserLayoutWebUIComponents;

public class _UserLayoutWebUIFooterComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}