using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ebuy.Web.Models;

namespace Ebuy.Web.Controllers
{
    public class AuctionsController : Controller
    {
        //
        // GET: /Actions/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(long id=0)
        {
            var action = new Ebuy.Web.Models.Auction
            {
                Id = id,
                Title = "Brand new Widget 2.0",
                Description = "This is a brand new version 2.0 Widget!",
                StartPrice = 1.00m,
                CurrentPrice = 13.40m,
                StartTime = DateTime.Parse("6-15-2012 12:34 PM"),
                EndTime = DateTime.Parse("6-15-2012 12:34 PM"),
            };
            return View(action);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            return View(auction);
        }
	}
}