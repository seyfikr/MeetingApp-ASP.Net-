
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{

    public class MeetingController : Controller
    {

        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            return View("Thanks", model);
        }
        public IActionResult List()
        {
            return View(Repository.Users);
        }
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}