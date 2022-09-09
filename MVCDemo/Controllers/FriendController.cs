using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public static List<Friend> friends { get; set; }


        //public IActionResult Details(int id)
        //{

        //}
        public IActionResult Details(int id)
        {
            Friend p = FriendService.Get(id);
            return View(p);
        }
        public IActionResult Lists()
        {
            List<Friend> friends = FriendService.GetAll();

            return View(friends);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Friend p)
        {
            FriendService.Add(p);

            return RedirectToAction("Lists");
        }

        public IActionResult Delete(int id)
        {
            Friend p = FriendService.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("Lists");

        }
        [HttpPost]
        public IActionResult Delete(Friend p)
        {
            FriendService.Delete(p.FriendId);
            return RedirectToAction("Lists");


        }
        public IActionResult Edit(int id)
        {

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Friend p)
        {
            object value = FriendService.Update(p.FriendId);
            return RedirectToAction("Lists");

        }
    }
}

