using GP.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProject.Controllers.FinancialAffairs
{
    [Authorize(Roles = "FinancialAffairs")]

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
        public IActionResult UpdateReceipt()
        {
            return RedirectToAction("ReceiptTable", "StudentAffairs");
        }
        [Authorize(Roles = "ManagerOfFinancialAffairs")]

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
