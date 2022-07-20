using AppointmentScheduling.Data;
using AppointmentScheduling.Models;
using AppointmentScheduling.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppointmentScheduling.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        UserManager<ApplicationUser> _userManager;

        SignInManager<ApplicationUser> _signInManager;
        RoleManager<IdentityRole> _roleManager;

        public AccountController(ApplicationDbContext db, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            
        }

        //Get Action Method - Login
        public IActionResult Login()
        {
            return View();
        }

        //Post Login Method


        //GET Register File 
        public async Task<IActionResult> Register()
        {
            if (!_roleManager.RoleExistsAsync(Helpers.Helper.Admin).GetAwaiter().GetResult())
            {
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Admin));
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Doctor));
                await _roleManager.CreateAsync(new IdentityRole(Helpers.Helper.Doctor));
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel pRegVM)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = pRegVM.Email,
                    Email = pRegVM.Email,
                    Name = pRegVM.Name
                };

                //When working with identity you have to store it into user manager
                //CreateSync expects a type of user 
                //Iaction must async Task as we are waiting to reg a user

                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, pRegVM.RoleName);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

            }
            return View();
            
        }
    }

}
