using Points.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Points.DataLayer;

namespace Points.Api
{
    public class PointController : ApiController
    {
        private PointRepository _manager;
        public PointController()
        {

        }

        [HttpGet]
        public ICollection<Point> Get(int listID) {
            return new List<Point>();
        }

        [HttpPost]
        public void AddPoint(int coordinateX, int coordinateY)
        {

        }
    }
}