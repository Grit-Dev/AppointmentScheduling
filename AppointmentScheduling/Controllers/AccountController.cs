using AppointmentScheduling.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheduling.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
            
        }

        //Get Action Method - Login
        public IActionResult Login()
        {
            return View();
        }

        //Post Login Method


        //GET Register File 
        public IActionResult Register()
        {
            return View();
        }
    }

}
