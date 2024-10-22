using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimUzmanligi.Ders12
{
    public class Sinif2 : Sinif3
    {

        public Sinif2(int paramSayi1,string paramMetin) : base()
        {
            
        }
        public int Sayi1 { get; set; }



        public void TestMetot()
        {
            Console.WriteLine("Ben Inheritence edilen sınıftan geliyorum.");
        }
    }
}
