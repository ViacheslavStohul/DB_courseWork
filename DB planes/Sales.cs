using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DB_planes
{
    [Table(Name = "Sales")]
    class Sales
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Ticket_Number { get; set; }

        [Column(IsPrimaryKey = true)]
        public int User_ID { get; set; }

        [Column(IsPrimaryKey = true)]
        public int Flight_Number { get; set; }

        [Column(IsPrimaryKey = true)]
        public int Plane_Number { get; set; }

        [Column]
        public DateTime Sale_Date { get; set; }

        [Column]
        public string Seat_Type { get; set; }

        [Column]
        public string Discont_Category { get; set; }

        [Column]
        public DateTime TakeOff_Date { get; set; }
    }
}
