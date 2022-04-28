using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using application.Models;

namespace application.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;

    public CategoryController(ILogger<CategoryController> logger)
    {
        _logger = logger;
    }

    [Route("Category/{id?}")]
    [Route("Category/{id?}/{id2?}")]
    public IActionResult Index(string id,string id2)
    {
        return View();
    }
   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
