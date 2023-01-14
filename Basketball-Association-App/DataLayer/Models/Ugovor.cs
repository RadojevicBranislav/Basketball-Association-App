using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Ugovor
    {
        public DateTime datum_potpisivanja { get; set; }

        public DateTime datum_isteka { get; set; }

        public int id_kosarkasa { get; set; }

        public int id_kluba { get; set; }


    }
}
