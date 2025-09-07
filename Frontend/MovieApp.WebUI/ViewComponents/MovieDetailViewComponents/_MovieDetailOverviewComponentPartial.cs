using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.ViewComponents.MovieDetailViewComponents;

public class _MovieDetailOverviewComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}