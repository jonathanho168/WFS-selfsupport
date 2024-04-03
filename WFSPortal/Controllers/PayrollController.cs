using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using WFSPortal.Data;
using WFSPortal.Models;

namespace WFSPortal.Controllers
{
    [Authorize] // Ensure only authorized (signed-in) users can access this controller
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
            var managerUsername = User.Identity.Name;

            // Retrieve time sheet listings for the signed-in manager
            var listings = await _context.GetTimeSheetListingsAsync(managerUsername);

            // Pass the listings to the view
            return View("~/Views/Payroll/Index.cshtml", listings);
        }

        public async Task<IActionResult> UnapproveTimesheet(Guid timesheetGUID)
        {
            var managerUsername = User.Identity.Name;

            // Call the UnapproveTimesheetAsync method on the context
            await _context.UnapproveTimesheetAsync(managerUsername, timesheetGUID);

            // Redirect to the index action method upon successful unapproval
            return RedirectToAction("Index");
        }
    }
}