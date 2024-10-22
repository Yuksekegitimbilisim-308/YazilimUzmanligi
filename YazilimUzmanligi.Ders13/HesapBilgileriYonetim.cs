namespace YazilimUzmanligi.Ders13
{
    public class HesapBilgileriYonetim
    {
        public HesapBilgileriYonetim()
        {
            Hesaplar = new List<HesapBilgileri>();
            SeedDataEkle();
        }
        private List<HesapBilgileri> Hesaplar { get; set; }
        /// <summary>
        /// Bu Metot Hesap Bilgileri Listeler. Geri Dönüş Tipi List<HesapBilgileri>
        /// </summary>
        /// <returns></returns>
        public List<HesapBilgileri> HesaplariGetir()
        {
            return Hesaplar;
        }
        /// <summary>
        /// Bu Metot Bir adet HesapBilgisi Nesnesi Dönecektir.
        /// </summary>
        /// <param name="id">Bu parametrede gönderilen id değeri listede aranır ve değer bulunursa geriye döner. Bulamazsa null değer dönecektir.</param>
        /// <returns></returns>
        public HesapBilgileri? HesapGetir(int id)
        {
            if (id > 0)
            {
                return Hesaplar.FirstOrDefault(x => x.Id == id);
            }
            return null;
        }
        /// <summary>
        /// Bu Metot Hesapların tutulduğu listeye yeni bir hesap ekler.
        /// </summary>
        /// <param name="hesap">Bu parametre eklenecek olan hesapbilgileri nesnesidir. Boş gönderilirse ekleme işlemi gerçekleşmeyecek.</param>
        /// <returns></returns>
        public bool HesapBilgisiEkle(HesapBilgileri hesap)
        {
            if (hesap != null)
            {
                int Id = Hesaplar.Count + 1;
                hesap.Id = Id;
                Hesaplar.Add(hesap);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Bu Metot Hesaplar listesinden hesapBilgisini siler.
        /// </summary>
        /// <param name="id">Bu parametrede gönderilen Id' ye sahip kayıt var ise o kayıdı listeden silecektir.</param>
        /// <returns></returns>
        public bool HesapBilgisiSil(int id)
        {
            HesapBilgileri? hesapBilgisi = Hesaplar.FirstOrDefault(x => x.Id == id);
            if (hesapBilgisi is not null)
            {
                Hesaplar.Remove(hesapBilgisi);
                return true;
            }
            return false;
        }
    /// <summary>
        /// Bu Metot Aldığı parametredeki değeri Mevcut değer ile Günceller.
        /// </summary>
        /// <param name="hesap">Bu parametre değiştirilecek olan hesapBilgisini içermektedir.</param>
        /// <returns></returns>
        public bool HesapBilgisiGuncelle(HesapBilgileri hesap)
        {
            HesapBilgileri? hesapBilgisi = Hesaplar.FirstOrDefault(x => x.Id == hesap.Id);
            if (hesapBilgisi != null)
            {
                hesapBilgisi.Bakiye = hesap.Bakiye;
                return true;
            }
            return false;
        }
        private void SeedDataEkle()
        {
            HesapBilgileri hesapBilgileri = new("Melih Ömer KAMAR", 12345, 500);
            HesapBilgileri hesapBilgileri1 = new("Abdullah ÇAVUŞ", 123456, 785);
            HesapBilgileri hesapBilgileri2 = new("Ömer Faruk KARAYİĞİT", 1234567, 298);
            HesapBilgileri hesapBilgileri3 = new("Batuhan GÖKKAYA", 12345678, 357);
            HesapBilgisiEkle(hesapBilgileri);
            HesapBilgisiEkle(hesapBilgileri1);
            HesapBilgisiEkle(hesapBilgileri2);
            HesapBilgisiEkle(hesapBilgileri3);
        }
    }
}
