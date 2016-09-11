using Points.DataLayer.Migrations;
using System.Data.Entity;

namespace Points
{
    public class PointsDatabaseIntializer : MigrateDatabaseToLatestVersion<RectangleContext, Configuration>
    {
        public override void InitializeDatabase(RectangleContext context)
        {
            base.InitializeDatabase(context);
        }
    }
}