using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
           // ViewBag.UserName = "Seyfi";
            ViewBag.selamlama = saat > 12 ? "iyi günler" : "Günaydın";
           int UserCount=Repository.Users.Where(i=> i.WillAttend==true).Count();


            var meetingInfo=new MeetingInfo()
            {
                Id=1,
                Location="Ankara",
                Date = new DateTime(2025, 5, 10, 14, 30, 0),
                NumberOfPeople=UserCount
            };
            return View(meetingInfo);
        }
    }
}
