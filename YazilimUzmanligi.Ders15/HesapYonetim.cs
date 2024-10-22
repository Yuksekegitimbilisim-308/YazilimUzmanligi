namespace YazilimUzmanligi.Ders15
{
    public class HesapYonetim
    {
        private readonly Random _random;
        private readonly Hesap _kullanici;
        public HesapYonetim(int kullaniciId)
        {
            _random = new Random();
            Hesaplar = new();
            SeedData();
            _kullanici = Hesaplar.FirstOrDefault(x => x.Id == kullaniciId);
        }
        private List<Hesap> Hesaplar { get; set; }
        //Hesapların Listesini Dönen Metot
        public List<Hesap> HesapListesiGetir()
        {
            return Hesaplar;
        }
        //Verilen id Parametresine Karşılık Gelen Hesabı Dönen Metot
        public Hesap HesapGetir(int id)
        {
            var hesap = Hesaplar.FirstOrDefault(x => x.Id == id);
            return hesap;
        }
        //Hesaplar Listesine Hesap Ekleyen Metot
        public void HesapEkle(Hesap hesap)
        {
            if (hesap != null)
            {
                int nextId = Hesaplar.Count + 1;
                hesap.Id = nextId;
                hesap.HesapNo = _random.Next(10000, 99999);
                Hesaplar.Add(hesap);
            }
        }
        //Bir Hesabın AdSoyad Alanını Güncelleyen Metot
        public void HesapGuncelle(int id, string adSoyad)
        {
            Hesap hesap = Hesaplar.FirstOrDefault(x => x.Id == id);
            if (string.IsNullOrEmpty(adSoyad) == false && hesap != null)
            {
                hesap.AdSoyad = adSoyad;
            }
        }
        //Bir Hesabı Hesaplar Listesinden Silen Metot
        public void HesapSilme(int id)
        {
            var hesap = Hesaplar.FirstOrDefault(x => x.Id == id);
            if (hesap != null)
            {
                Hesaplar.Remove(hesap);
            }
        }
        //Kullanıcı Hesabından Para Çekme İşlemini Yapan Metot
        public void ParaCekme(double cekilenTutar)
        {

            if (_kullanici.Bakiye >= cekilenTutar && cekilenTutar > 0)
            {
                _kullanici.Bakiye -= cekilenTutar;
            }
        }
        //Kullanıcı Hesabına Para Ekleme Metodu
        public void ParaYatirma(double yatirilanTutar)
        {

            if (yatirilanTutar > 0)
            {
                _kullanici.Bakiye += yatirilanTutar;
            }
        }
        //Kullanıcı Hesabından Başka Bir Hesaba Para Gönderen Metot
        public void ParaGonder(int aliciId, double gonderilenTutar)
        {
            var alici = Hesaplar.FirstOrDefault(x => x.Id == aliciId);
            if (gonderilenTutar > 0 && _kullanici.Bakiye >= gonderilenTutar)
            {
                _kullanici.Bakiye -= gonderilenTutar;
                alici.Bakiye += gonderilenTutar;
            }
        }
        private void SeedData()
        {
            HesapEkle(new Hesap() { AdSoyad = "Melih Ömer KAMAR", Bakiye = 500 });
            HesapEkle(new Hesap() { AdSoyad = "Abdullah ÇAVUŞ", Bakiye = 1870 });
            HesapEkle(new Hesap() { AdSoyad = "Batuhan GÖKKAYA", Bakiye = 6214 });
            HesapEkle(new Hesap() { AdSoyad = "Ömer Faruk KARAYİĞİT", Bakiye = 3659 });
            HesapEkle(new Hesap() { AdSoyad = "Tuğba DEMİR", Bakiye = 128 });
        }
    }
}
