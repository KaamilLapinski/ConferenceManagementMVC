using ConferenceManagementMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagementMVC.Web.Controllers
{
    public class ConferenceController : Controller
    {
        public IActionResult ViewListOfConferences()
        {
            List<Conference> conferences = new List<Conference>();
            conferences.Add(new Conference() { Id = 1});
            conferences.Add(new Conference() { Id = 2 });
            conferences.Add(new Conference() { Id = 3 });
            return View(conferences);
        }

    }
}
