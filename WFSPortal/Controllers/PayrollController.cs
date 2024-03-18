using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WFSPortal.Models;

namespace WFSPortal.Controllers;

public class PayrollController : Controller
{
    private readonly ILogger<PayrollController> _logger;

    public PayrollController(ILogger<PayrollController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

