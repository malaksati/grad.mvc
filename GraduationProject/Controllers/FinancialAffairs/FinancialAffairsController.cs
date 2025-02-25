using GP.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.FinancialAffairs
{
    public class FinancialAffairsController : Controller
    {
        private readonly AppDbContext _context;

        public FinancialAffairsController(AppDbContext context)
        {
            _context = context; // Dependency Injection
        }
        public IActionResult PaymentDetails()
        {
            return View();
        }
        public IActionResult Receipt()
        {
            return View();
        }
        public IActionResult AddReceipt()
        {
            return View("PaymentDetails");
        }
        public IActionResult ManagerStats()
        {
            return View();
        }
        public IActionResult PetitonRequest()
        {
            return View();
        }
    }
}
