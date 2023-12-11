using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace group_v1.Controllers;

public class HelloWorldController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    
    // // 
    // // GET: /HelloWorld/
    // public string Index()
    // {
    //     return "This is my default action...";
    // }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}