using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace P_Urban_WebbApp.Controllers
{
    public class GetController : Controller
    {

        public IActionResult Index(String name)
        {

            // ViewData["name"] = HtmlEncoder.Default.Encode("Tu metoda Index GetControllera" + name);
            ViewData["name"] = name;
            return View();
        }
    }
}