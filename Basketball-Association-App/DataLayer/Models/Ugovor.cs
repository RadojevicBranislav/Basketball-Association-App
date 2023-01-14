using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Ugovor
    {
        private DateTime datum_potpisivanja { get; set; }

        private DateTime datum_isteka { get; set; }

        private int id_kosarkasa { get; set; }

        private int id_kluba { get; set; }


    }
}
