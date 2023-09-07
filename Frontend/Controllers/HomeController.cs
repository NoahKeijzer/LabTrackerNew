using System.Diagnostics;
using Domain;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var vm = new List<StudentOpdrachtVoortgang>
        {
            new ()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Noah de Keijzer" },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.Afgerond
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Stefan So " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.Bezig
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
            new()
            {
                StudentId = Guid.NewGuid(),
                Student = new Student { Name = "Kees Koning " },
                Opdracht = new Opdracht
                {
                    OpdrachtId = Guid.NewGuid(), Naam = "Test 1"
                },
                Voortgang = Voortgang.ZitVast
            },
        };
        return View(vm);
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
}