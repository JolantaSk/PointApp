using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points.DataLayer
{
    public static class Bootstraper
    {
        public static void Initialize()
        {
            Database.SetInitializer(new PointsDatabaseIntializer());
        }
    }
}
