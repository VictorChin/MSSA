using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "<b>This is my default action...</b>";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

    public string Welcome(string name, int blahblah = 1)
{
       return HtmlEncoder.Default.Encode($"Hello {name}, ID: {blahblah}");
}
    }
}