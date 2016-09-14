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
            _manager = new PointRepository();
        }

        [HttpGet]
        public ICollection<Point> Get(int listID) {
            return new List<Point>();
        }

        [HttpPost]
        public void AddPoint(int coordinateX, int coordinateY, int listID)
        {
            _manager.AddPoint(new Point
            {
                CoordinateX = coordinateX,
                CoordinateY = coordinateY,
                ListId = listID
            });
        }

        [HttpPost]
        public void RemovePoint(int pointID, int listID)
        {
            _manager.RemovePoint(pointID, listID);
        }
    }
}