using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JTI.Models;

namespace JTI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            ViewData["Message"] = "Escriba sus credenciales de inicio";
            return View();
        }

        
    }
}
