using Points.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Points
{
    public class RectangleContext : DbContext
    {
        public RectangleContext() 
            : base("DefaultConnection")
        {

        }

        public DbSet<Point> Points { get; set; }
        public DbSet<List> Lists { get; set; }

        }
}