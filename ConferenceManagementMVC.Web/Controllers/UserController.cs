using ConferenceManagementMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagementMVC.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ViewListOfUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Email = "new@o2.pl", Password = "haslo", Name = "Kamil", LastName = "Lapinski", Role = Models.Enums.RoleUser.Admin });
            users.Add(new User() { Id = 2, Email = "new2@o2.pl", Password = "haslo2", Name = "janek", LastName = "Kowalski", Role = Models.Enums.RoleUser.Member });
            users.Add(new User() { Id = 3, Email = "new2@o2.pl", Password = "haslo3", Name = "Andrzej", LastName = "Musial", Role = Models.Enums.RoleUser.Chairman });
            users.Add(new User() { Id = 4, Email = "new4@o2.pl", Password = "haslo4", Name = "Kamila", LastName = "Nowak", Role = Models.Enums.RoleUser.Speaker });

            return View(users);
        }
    }
}
