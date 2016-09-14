using Points.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points.DataLayer
{
    public class PointRepository
    {
        private const int MaxPointCoordValue = 5000;
        private const int MaxListSize = 10000;

        public void AddPoint(Point point)
        {
            using (var ctx = new RectangleContext())
            {
                var list = ctx.Lists.Find(point.ListId);
                if (!DoesPointExist(list.Points, point) & DoesPointFitInRange(point) & IsListSizeNotExceeded(list.Points))
                    list.Points.Add(point);

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
                    if (!DoesPointExist(currentList.Points, point) & DoesPointFitInRange(point) & IsListSizeNotExceeded(currentList.Points))
                    {
                        currentList.Points.Add(point);
                    }
                }

                ctx.SaveChanges();
            }
        }

        public void ClearFromList(int listID)
        {
            using (var ctx = new RectangleContext())
            {
                ctx.Lists.Find(listID).Points.Clear();
                ctx.SaveChanges();
            }
        }

        public void RemovePoint(int pointId, int listId)
        {
            using (var ctx = new RectangleContext())
            {
                var point = ctx.Points.Where(x => x.Id == pointId && x.ListId == listId).SingleOrDefault();
                if (point != null)
                {
                    ctx.Points.Remove(point);
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

        private bool IsListSizeNotExceeded(ICollection<Point> list)
        {
            return list.Count <= MaxListSize;
        }
    }
}
