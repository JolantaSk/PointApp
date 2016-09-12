using Points.DataLayer.dto;
using Points.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points.DataLayer
{
    public class ListRepository
    {
        public ICollection<Point> GetList(int listId)
        {
            using (var ctx = new RectangleContext())
            {
                return ctx.Lists.Find(listId).Points;
            }
        }

        public void DeleteList(int listID)
        {
            using (var ctx = new RectangleContext())
            {
                ctx.Lists.Remove(ctx.Lists.Find(listID));
                ctx.SaveChanges();
            }
        }

        public ICollection<ReducedList> GetAllLists()
        {
            using (var ctx = new RectangleContext())
            {
                return ctx.Lists.Select(x => new ReducedList(){ Id = x.Id, Name = x.Name }).ToList();
            }
        }
    }
}
