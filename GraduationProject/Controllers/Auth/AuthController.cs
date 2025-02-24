using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace GraduationProject.Controllers.Auth
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            return RedirectToAction("Index", "Home");
        }
        //public IActionResult Logout()
        //{
        //    return View();
        //}
        public IActionResult ForgetPassword()
        {
            return View("ForgetPassword");
        }
        public IActionResult VerifyEmail()
        {
            return Redirect("ForgetPassword");
        }
        public IActionResult VerifyCode()
        {
            return View("NewPassword");
        }
        public IActionResult VerifyPassword()
        {
            return View("Login");
        }
    }
}
