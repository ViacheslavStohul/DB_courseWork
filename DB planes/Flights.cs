using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
namespace DB_planes
{
    [Table(Name = "Flights")]
    class Flights
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Flight_Number { get; set; }

        [Column(IsPrimaryKey = true)]
        public int Plane_Number { get; set; }

        [Column]
        public DateTime TakeOff_Date { get; set; }

        [Column]
        public DateTime Landing_Date { get; set; }

        [Column]
        public string TakeOff_City { get; set; }

        [Column]
        public string Landing_City { get; set; }
    }
}
