using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;


namespace JTI.Controllers
{
    public class Login2Controller : Controller
    {
        public IActionResult Login2()
        {
            return View();
        }
    }
}