using Microsoft.AspNetCore.Mvc;
using MovieApp.Dto.Dtos.UserRegisters;

namespace MovieApp.WebUI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegisterController:Controller
{
    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SignUp(CreateUserRegisterDto userRegisterDto)
    {
        return RedirectToAction("SignIn","Login");
    }
    
}