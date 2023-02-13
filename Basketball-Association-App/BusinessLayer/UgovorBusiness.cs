using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UgovorBusiness
    {
        private UgovorRepository ugovorRepository = new UgovorRepository();

        public List<Ugovor> getUgovori()
        {
            return ugovorRepository.GetUgovors();
        }

        public bool insertUgovor(Ugovor ugovor)
        {
            return ugovorRepository.InsertUgovor(ugovor) > 0;
        }
    }
}
