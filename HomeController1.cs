using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Net.Security;
using System.Text.Encodings.Web;

namespace baitap1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int NumTimes = 2)
        {
            ViewBag.Message = "tranthanh" + name;
            ViewData["numTimes"] = NumTimes;
            return View();
        }
    }
}
