using Points.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points.DataLayer
{
    class PointManager
    {
        private const int MaxPointCoordValue = 5000;
        public void AddPoint(Point point, int listId)
        {
            using (var ctx = new RectangleContext())
            {
                var list = ctx.Lists.Find(listId);
                if (!DoesPointExist(list.Points, point) & DoesPointFitInRange(point))
                    list.Points.Add(point);

                ctx.Lists.Add(list);
                ctx.SaveChanges();
            }
        }

        public void AddPointList(ICollection<Point> newList, int listId)
        {
            using (var ctx = new RectangleContext())
            {
                var currentList = ctx.Lists.Find(listId);
                if (currentList == null)
                    currentList = new List();

                foreach (var point in newList)
                {
                    if (!DoesPointExist(currentList.Points, point) & DoesPointFitInRange(point))
                    {
                        currentList.Points.Add(point);
                    }
                }

                ctx.SaveChanges();
            }
        }

        public void RemovePoint(Point point, int listId)
        {
            using (var ctx = new RectangleContext())
            {
                var list = ctx.Lists.Find(listId);
                if (!DoesPointExist(list.Points, point))
                {
                    list.Points.Remove(point);
                }
                ctx.SaveChanges();
            }
        }

        private bool DoesPointExist(ICollection<Point> list, Point point)
        {
            return list.Any(x => x.CoordinateX == point.CoordinateX & x.CoordinateY == point.CoordinateY);
        }

        private bool DoesPointFitInRange(Point point)
        {
            return Math.Abs(point.CoordinateX) <= MaxPointCoordValue & Math.Abs(point.CoordinateY) <= MaxPointCoordValue;
        }
    }
}
