using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models;

namespace MvcWebApp.Controllers;

public  class EmployeeController : Controller
{
    
    public IActionResult number()
    {
        return View();
    }

    public IActionResult name()
    {
        return View();
    }
}