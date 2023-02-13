using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KosarkasBusiness
    {
        private KosarkasRepository kosarkasRepository = new KosarkasRepository();

        public List<Kosarkas> GetKosarkasi()
        {
            return kosarkasRepository.GetKosarkasi();
        }

        public bool insertKosarkas(Kosarkas kosarkas)
        {
            return kosarkasRepository.InsertKosarkas(kosarkas) > 0;
        }

        public bool deleteKosarkas(int kosarkasId)
        {
            return kosarkasRepository.DeleteKosarkas(kosarkasId) > 0;
        }

        public Kosarkas getKosarkasById(int kosarkasId)
        {
            return kosarkasRepository.GetKosarkasById(kosarkasId);
        }

    }
}
