using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PG.Models
{
    public class Pg_Owner
    {
        public int Id { get; set; }
        public string PgName { get; set; }
        public string Address { get; set; }
        public int Contact { get; set; }
        public string Gender { get; set; }
        public int Vacancy { get; set; }
        public float Rent { get; set; }
        public bool IsAc { get; set; }

    }
}
