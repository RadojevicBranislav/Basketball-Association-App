using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KlubBusiness
    {
        private KlubRepository klubRepository = new KlubRepository();

        public List<Klub> GetKlubs()
        {
            return klubRepository.GetKlubs();
        }

        public bool insertKlub(Klub klub)
        {
            return klubRepository.InsertKlub(klub) > 0;
        }

        public bool deleteKlub(int id)
        {
            return klubRepository.Deleteklub(id) > 0;
        }

        public bool UpdateKlub(int id, string newName)
        {
            return klubRepository.UpdateKlubName(id, newName) > 0;
        }

        public Klub GetKlubById(int id)
        {
            return klubRepository.GetKlubById(id);
        }

    }
}
