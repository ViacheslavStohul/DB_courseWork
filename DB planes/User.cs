using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DB_planes
{
    [Table(Name = "Users")]
    class User
    { 
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int User_Id { get; set; }

        [Column]
        public string Username { get; set; }

        [Column]
        public int Control_Level { get; set; }

        [Column]
        public string Password { get; set; }

        [Column]
        public string First_Name { get; set; }

        [Column]
        public string Last_Name { get; set; }

        [Column]
        public int age { get; set; }
    }
}
