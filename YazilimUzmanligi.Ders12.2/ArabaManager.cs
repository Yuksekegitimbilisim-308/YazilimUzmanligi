using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimUzmanligi.Ders12._2
{
    public class ArabaManager
    {
        public ArabaManager()
        {
            Arabalar = new();
        }
        private List<Araba> Arabalar { get; set; }
        public void ArabaEkle(Araba araba)
        {
            int yeniId = Arabalar.Count + 1;
            if (araba != null)
            {
                araba.Id = yeniId;
                Arabalar.Add(araba);
            }
        }
        public void ArabaSil(int id)
        {

            var deger = Arabalar.FirstOrDefault(x => x.Id == id);
            if (deger != null)
            {
                Arabalar.Remove(deger);
            }
        }
        public List<Araba> ArabaListele()
        {

            return Arabalar;
        }
    }
}
