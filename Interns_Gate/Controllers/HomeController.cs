﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Interns_Gate.Models;

namespace Interns_Gate.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    // test github
    public HomeController(ILogger<HomeController> logger)
    {

   
        _logger = logger;
    }

    public IActionResult Index()
    {
        String g = "";
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
}

