using System.Web.Mvc;
using SimpleWizardForm.Models;

namespace SimpleWizardForm.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View("SimpleWizardForm");
        }

        //
        // POST: /Home/
        [HttpPost]
        public ActionResult Index(SimpleWizardFormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("SimpleWizardFormSuccess");
            }

            // Just for testing in order to know when it is the serverside validation that has failed
            ModelState.AddModelError("", "Server-side validation failed.");

            // If we got this far something failed, redisplay form
            return View("SimpleWizardForm", model);
        }
    }
}