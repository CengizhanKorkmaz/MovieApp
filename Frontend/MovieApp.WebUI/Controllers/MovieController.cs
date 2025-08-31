using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.Controllers;

public class MovieController:Controller
{
    public IActionResult MovieList()
    {
        ViewBag.v1 = "Movies List";
        ViewBag.v2 = "Home";
        ViewBag.v3 = "Movies";
        return View();
    }
    
}