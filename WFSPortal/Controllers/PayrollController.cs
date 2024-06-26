using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using WFSPortal.Models;
using System.Numerics;

namespace WFSPortal.Controllers
{
    // [Authorize] // Ensure only authorized (signed-in) users can access this controller
    public class PayrollController : Controller
    {
        private readonly Epicorhcmcmu2024Context _context;

        public PayrollController(Epicorhcmcmu2024Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Assuming the manager's username is stored as the user's name
            var managerUsername = User.Identity.Name ?? "WFS_ANON";

            // Retrieve time sheet listings for the signed-in manager
            var listings = await _context.GetTimeSheetListingsAsync(managerUsername);
            
            // Pass the listings to the view
            return View("~/Views/Payroll/Index.cshtml", listings);
        }

        [HttpPost]
        public async Task<IActionResult> UnapproveTimesheet(Guid timesheetId)
        {
            // Assuming the manager's username is stored as the user's name
            var managerUsername = User.Identity.Name ?? "WFS_ANON";

            // Call UnapproveTimeSheetAsync method from _context using managerUsername and timesheetId
            await _context.UnapproveTimeSheetAsync(timesheetId, managerUsername);

            // Redirect to the Index action after unapproving the timesheet
            return RedirectToAction("Index");
        }

    }
}
