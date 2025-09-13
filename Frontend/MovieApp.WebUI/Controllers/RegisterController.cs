using System.Text;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Dto.Dtos.UserRegisters;
using Newtonsoft.Json;

namespace MovieApp.WebUI.Controllers;


public class RegisterController(IHttpClientFactory httpClientFactory):Controller
{
    
    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(CreateUserRegisterDto userRegisterDto)
    {
        var client = httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(userRegisterDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8,"application/json");
        var response = await client.PostAsync("http://localhost:5001/api/UserRegister", stringContent);
        
        if (!response.IsSuccessStatusCode)
            ViewBag.error = "Kayıt işlemi başarısız oldu. Lütfen bilgilerinizi kontrol edip tekrar deneyiniz.";
        
        return RedirectToAction("SignIn","Login");
    }
    
}