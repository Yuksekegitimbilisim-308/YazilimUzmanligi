using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimUzmanligi.Ders12
{
    public class Sinif1 : Sinif2
    {
        int sayi = 5;
        public Sinif1(int paramSayi1,string paramMetin) : base(paramSayi1,paramMetin)
        {
            paramSayi1 = sayi;
        }

        public int Sayi2 { get; set; }
    }
}
