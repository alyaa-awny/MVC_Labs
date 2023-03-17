using Lab2.Models;
using Lab2.Models.Domain;
using Lab2.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers;

public class ActorController : Controller
{
    public IActionResult Index()
    {

        return View("ActorVMIndex");
    }
    [HttpGet]
    public IActionResult ShowForm()
    {
        var countries = Country.GetCountries();
        // ViewBag.Countries = countries;
        ViewData[MagicString.Countries] = countries;
        return View();
    }
    public IActionResult AddNewActor(AddActorVM actorVM)
    {


        return RedirectToAction(nameof(Index));
    }
}
