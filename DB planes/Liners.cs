using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DB_planes
{
    [Table(Name = "Liners")]
    class Liners
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Board_Number { get; set; }

        [Column(IsPrimaryKey = true)]
        public int Type { get; set; }

        [Column]
        public DateTime Last_check { get; set; }

        [Column]
        public int business_places { get; set; }

        [Column]
        public int business_cost { get; set; }

        [Column]
        public int FirstClass_places { get; set; }

        [Column]
        public int FirstClass_cost { get; set; }

        [Column]
        public int SecondClass_places { get; set; }

        [Column]
        public int SecondClass_cost { get; set; }
    }
}
