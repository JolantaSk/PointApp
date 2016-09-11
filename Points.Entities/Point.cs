using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Points.Entities
{
    public class Point
    {
        [Key]
        public int Id { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public int ListId { get; set; }

        [ForeignKey(nameof(ListId))]
        public virtual List List { get; set; }
    }
}