using Points.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Points.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new RectangleContext())
            {
                var l = new List()
                {
                    Points = new[]
                    {
                        new Point
                        {
                            CoordinateX = 1,
                            CoordinateY = 2,
                        }
                    }
                };

                ctx.Lists.Add(l);
                ctx.SaveChanges();
            }
            return View();
        }
    }
}
