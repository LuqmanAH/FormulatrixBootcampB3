using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC_Demo;

public class SampleController : Controller
{
    //
    // GET: /HelloWorld/
    public string Index()
    {
        return "Al-Indeqqqs";
    }
    //
    // GET: /HelloWorld/Welcome
    public string Welcome()
    {
        return "Welkam tu mobalejen..";
    }
}
