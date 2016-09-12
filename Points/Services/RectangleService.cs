using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Points.DataLayer;
using Points.Entities;

namespace Points.Services
{
    public class RectangleService
    {
        private ListRepository _listManager;
        public RectangleService ()
        {
            _listManager = new ListRepository();
        }

        public int CountNumberOfRectangles(int listId)
        {
            var list = _listManager.GetList(listId);


            return 0;
        }

        public double GetDistanceBetweenPoints(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.CoordinateX - p2.CoordinateX, 2) + Math.Pow(p2.CoordinateY - p2.CoordinateY, 2));
        }
    }
}