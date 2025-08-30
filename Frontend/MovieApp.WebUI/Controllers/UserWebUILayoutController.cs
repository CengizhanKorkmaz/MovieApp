using Microsoft.AspNetCore.Mvc;

namespace MovieApp.WebUI.Controllers;


public class UserWebUILayoutController:Controller
{
    public IActionResult LayoutUI()
    {
        return View();
    }
}