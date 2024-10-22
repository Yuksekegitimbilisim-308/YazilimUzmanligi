using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimUzmanligi.Ders14
{
    public class PersonelYonetim
    {
        public PersonelYonetim()
        {
            Personeller = new();
            SeedData();
        }
        public List<Personel> Personeller { get; set; }

        private void SeedData()
        {
            Personeller.Add(new() { Id = 1, AdSoyad = "Melih Ömer Kamar", CalismaSuresi = 5, Maas = 25000, Pozisyon = "Muhasebe", Durum = false });
            Personeller.Add(new() { Id = 2, AdSoyad = "Batuhan Gökkaya", CalismaSuresi = 2, Maas = 35000, Pozisyon = "Yazılım", Durum = true });
            Personeller.Add(new() { Id = 3, AdSoyad = "Ömer Faruk Karayiğit", CalismaSuresi = 7, Maas = 27500, Pozisyon = "Muhasebe", Durum = true });
            Personeller.Add(new() { Id = 4, AdSoyad = "Abdullah Çavuş", CalismaSuresi = 3, Maas = 46000, Pozisyon = "İK", Durum = true });
            Personeller.Add(new() { Id = 4, AdSoyad = "Habibe Çınar", CalismaSuresi = 1, Maas = 25000, Pozisyon = "Yazılım", Durum = false });
            Personeller.Add(new() { Id = 4, AdSoyad = "Tuğba Demir", CalismaSuresi = 4, Maas = 29175, Pozisyon = "İK", Durum = false });
        }
        // Çalışma Süresi 2 yıla eşit veya  fazla olan pozisyonu yazılım olan personellerin listesi
        public List<Personel> Filtre1()
        {
            var list = Personeller.Where(x => x.CalismaSuresi >= 2 && x.Pozisyon == "Yazılım").ToList();
            return list;
        }
        // Maaşı 25000 den yüksek ve çalışma durumları aktif olan personeller
        public List<Personel> Filtre2()
        {
            //lambda - x => x && (shift + 6) || (alt gr + -)
            return Personeller.Where(personel => personel.Maas > 25000 && personel.Durum).ToList();
        }
        // Çalışma Süresi 5 ten büyük ve maaşı 25000 den fazla olan veya çalışma süresi 5 ten küçük ve durumu aktif olan personeller.
        public List<Personel> Filtre3()
        {
            var list = Personeller
                .Where(x => 
                (x.CalismaSuresi > 5 && x.Maas > 25000)
                || 
                (x.CalismaSuresi < 5 && x.Durum)).ToList();
            return list;
        }
    }

}
