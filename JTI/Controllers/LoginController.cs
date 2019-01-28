using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JTI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace JTI.Controllers 
{
    public class LoginController : Controller
    {

        /*Método captura los datos que vienen desde el formulario, por get*/
        public IActionResult Login()
        {
            return View();
        }

        /*Método captura los datos que vienen desde el formulario, por post*/
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuarios usuarios)
        {
            if(ModelState.IsValid)
            {


            }
            return View(usuarios);
        }
       
       



    }
}
