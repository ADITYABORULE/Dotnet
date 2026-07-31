using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using MvcWebApp.models;

namespace MvcWebApp.Controllers;

public class Student : Controller
{
     public IActionResult Speak()
    {
        return View();
    }

    public IActionResult eat()
    {
        
        return View();
    }

}