namespace YazilimUzmanligi.Ders13._2
{
    public class OgrenciYonetim
    {
        public OgrenciYonetim()
        {
            Ogrenciler = new();
            SeedData();
        }
        private List<Ogrenci> Ogrenciler { get; set; }

        //1. Adım Verilerin Listesini Geriye Dönen metot
        public List<Ogrenci> OgrenciListele()
        {
            return Ogrenciler;
        }
        //2. Adım yeni bir öğrenci kayıt metodu
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            if (ogrenci.AdSoyad is not null)
            {
                int Id = Ogrenciler.Count + 1;
                ogrenci.Id = Id;
                Ogrenciler.Add(ogrenci);
            }
        }
        //3. Adım Listeden Öğrenci Silme metodu
        public void OgrenciSil(int id)
        {
            Ogrenci? ogrenci = Ogrenciler.FirstOrDefault(x => x.Id == id);
            if (ogrenci != null)
            {
                Ogrenciler.Remove(ogrenci);
            }
        }
        //4. Adım Listedeki Öğrencinin Değerlerinde Güncelleme metodu
        public void OgrenciGuncelle(Ogrenci paramOgrenci)
        {
            Ogrenci? ogrenci = Ogrenciler.FirstOrDefault(x => x.Id == paramOgrenci.Id);
            if (ogrenci is not null)
            {
                ogrenci.AdSoyad = paramOgrenci.AdSoyad;
                ogrenci.Sinif = paramOgrenci.Sinif;
                ogrenci.Durumu = paramOgrenci.Durumu;
            }

        }
        //5. Adım Id ye göre bir adet öğrenci geri dönen metot
        public Ogrenci? OgrenciGetir(int id)
        {
            if (id > 0)
            {
                return Ogrenciler.FirstOrDefault(x => x.Id == id);
            }
            return null;
        }
        //6. Adım Öğrencilik Durumu Sadece Aktif Olanları Getiren Metot
        public List<Ogrenci> AktifOgrencilerinListesi()
        {
            var ogrenciler = Ogrenciler.Where(x => x.Durumu).ToList();
            return ogrenciler;
        }
        //7. Adım Sınıfa Göre Filtreleme metodu
        public List<Ogrenci> SinifaGoreOgrenciler(int sinif)
        {
            var ogrenciler = Ogrenciler.Where(x => x.Sinif == sinif).ToList();
            return ogrenciler;
        }
        //8. Adım Alınan Parametre İle Başlayan İsimli Öğrencilerin Listesi.
        public List<Ogrenci> IsimSoyisimArama(string aranacakKelime)
        {
            var bulunanOgrenciler = Ogrenciler
                .Where(x => x.AdSoyad
                .StartsWith(aranacakKelime))
                .ToList();
            return bulunanOgrenciler;
        }
        //9. Adım Alınan Parametredi Sınıfa ve Duruma Göre Uygun Olan Öğrencilerin Listesini Dönen Filtre Metot.
        public List<Ogrenci> SinifVeDurumaGoreFiltre(int sinif, bool durum)
        {
            return Ogrenciler.Where(x => x.Sinif == sinif && x.Durumu == durum).ToList();
        }
        private void SeedData()
        {
            Ogrenciler.Add(new Ogrenci() { Id = 1, AdSoyad = "Ömer Melih KAMAR", Durumu = false, Sinif = 308 });
            Ogrenciler.Add(new Ogrenci() { Id = 2, AdSoyad = "Batuhan GÖKKAYA", Durumu = true, Sinif = 302 });
            Ogrenciler.Add(new Ogrenci() { Id = 3, AdSoyad = "Ömer Faruk KARAYİĞİT", Durumu = true, Sinif = 308 });
            Ogrenciler.Add(new Ogrenci() { Id = 4, AdSoyad = "Abdullah ÇAVUŞ", Durumu = true, Sinif = 302 });
            Ogrenciler.Add(new Ogrenci() { Id = 5, AdSoyad = "Ahmet KARA", Durumu = false, Sinif = 309 });
            Ogrenciler.Add(new Ogrenci() { Id = 6, AdSoyad = "Ayşe ÇELİK", Durumu = true, Sinif = 304 });
            Ogrenciler.Add(new Ogrenci() { Id = 7, AdSoyad = "Habibe ÇINAR", Durumu = true, Sinif = 307 });
            Ogrenciler.Add(new Ogrenci() { Id = 8, AdSoyad = "Hayriye LİMON", Durumu = false, Sinif = 307 });
        }
    }
}
