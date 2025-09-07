
using Microsoft.AspNetCore.Mvc;
using MovieApp.Dto.Dtos.Movies;
using Newtonsoft.Json;

namespace MovieApp.WebUI.Controllers;

public class MovieController(IHttpClientFactory httpClientFactory):Controller
{
    public async Task<IActionResult> MovieList()
    {
        ViewBag.v1 = "Movies List";
        ViewBag.v2 = "Home";
        ViewBag.v3 = "Movies";
        var client = httpClientFactory.CreateClient();
        var responseMessage= await client.GetAsync("http://localhost:5001/api/Movie");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<GetAllMovieDto>>(jsonData);
            return View(data);
        }

        return View();
    }

    public async Task<IActionResult> MovieDetail(int id)
    {
        return View();
    }
    
}