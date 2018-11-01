using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionSiteProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckIn()
        {
            ViewBag.Message = "Bidder Check In";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Payments()
        {
            ViewBag.Message = "Payment page.";

            return View();
        }
        public ActionResult SilentAuction()
        {
            ViewBag.Message = "Silent Auction page.";

            return View();
        }
<<<<<<< HEAD

        public ActionResult NewItem()

        {
            ViewBag.Message = "New Item page.";
            return View();

=======
        public ActionResult NewItem()
        {
            ViewBag.Message = "New Item page.";

            return View();
>>>>>>> 0f4864e4805f7cf56e08de7955212343024bf6a0
        }
    }
}