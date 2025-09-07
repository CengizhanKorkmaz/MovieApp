using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.ViewComponents.MovieDetailViewComponents;

public class _MovieDetailRateComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}