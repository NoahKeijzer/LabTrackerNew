﻿using System.Diagnostics;
using Domain;
using Domain.Models;
using DomainServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository<StudentOpdrachtVoortgang> _sovRepository;
    public HomeController(ILogger<HomeController> logger, IRepository<StudentOpdrachtVoortgang> sovRepository)
    {
        _logger = logger;
        _sovRepository = sovRepository;
    }

    public IActionResult Index()
    {
        var vm = new List<StudentOpdrachtVoortgang>
        {
            new ()
            {
                Student = new Student { Name = "Noah de Keijzer" },
                Opdracht = new Opdracht { Naam = "Test 1" },
                Voortgang = Voortgang.Afgerond
            },
            new()
            {
                Student = new Student { Name = "Sefan So " },
                Opdracht = new Opdracht { Naam = "Test 2"},
                Voortgang = Voortgang.ZitVast
            }
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

    public void UpdateVoortgang(StudentOpdrachtVoortgang sov)
    {
        _sovRepository.Update(sov);
    }
}