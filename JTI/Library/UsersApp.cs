using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JTI.Library
{
    public class UsersApp : ListaObjetos
    {
        public UsersApp()
        {

        }

        public UsersApp(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _usersRole = new UserRoles();
        }

        public UsersApp(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _usersRole = new UserRoles();
        }

        internal async Task<List<object[]>> userLogin(string usuario, string password)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(usuario, password, false,
                    lockoutOnFailure: false);
                if(result.Succeeded)
                {
                    var appUser = _userManager.Users.Where(u => u.UserName.Equals(usuario)).ToList();

                }
                else
                {
                    code = "1";
                    description = "Usuario o Password inválidos";

                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
