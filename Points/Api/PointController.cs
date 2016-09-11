using Points.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Points.Api
{
    public class PointController : ApiController
    {
        public PointController()
        {

        }

        [HttpGet]
        public IEnumerable<Point> Get() {
            return new List<Point>();
        }

        [HttpPost]
        public void AddPoint(int coordinateX, int coordinateY)
        {

        }
    }
}