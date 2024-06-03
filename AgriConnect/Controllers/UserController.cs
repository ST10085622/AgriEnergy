using Microsoft.AspNetCore.Mvc;
using AgriEnergy.Models; //importing the models to access the properties

namespace AgriEnergy.Controllers
{
    public class UserController : Controller
    {
        // GET: Account/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Here Im checking the credentials against my database, agri-energy
            bool isAuthenticated = AuthenticateUser(model.Username, model.Password);

            if (isAuthenticated)
            {
                // If authenticated, redirect to another page or perform other actions
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View(model);
            }
        }

        //this where i authenticate the user(s), the employee and farmers combined
        private bool AuthenticateUser(string username, string password)
        {
            
            return false;


        }
    }
}
