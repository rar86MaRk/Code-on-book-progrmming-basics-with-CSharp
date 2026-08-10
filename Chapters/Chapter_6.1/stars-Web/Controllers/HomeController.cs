using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Raiting.Models;

namespace Raiting.Controllers;

public class HomeController : Controller
{
        private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public ActionResult DrawRating(int rating)
    {
        var fullStars = rating * 10 / 100;
        var emptyStars = (100 - rating) * 10 / 100;
        var halfStars = 10 - fullStars - emptyStars;

        var stars = "";

        for (int i = 0; i < fullStars; i++)
        {
            stars += "<img src = '/images/full-star.png' />";
        }
        for (int i = 0; i < halfStars; i++)
        {
            stars += "<img src = '/images/half-star.png' />";
        }
        for (int i = 0; i < emptyStars; i++)
        {
            stars += "<img src = '/images/empty-star.png' />";
        }

        ViewBag.Stars = stars;
        ViewBag.Rating = rating;
        return View("Index");
    }
}
