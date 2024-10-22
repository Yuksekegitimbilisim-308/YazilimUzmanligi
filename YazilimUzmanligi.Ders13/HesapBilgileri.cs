namespace YazilimUzmanligi.Ders13
{
    public class HesapBilgileri
    {
        public HesapBilgileri()
        {
            
        }
        public HesapBilgileri(string adSoyad,int hesapNo,double bakiye)
        {
            AdSoyad = adSoyad;
            HesapNo = hesapNo;
            Bakiye = bakiye;
        }
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public int HesapNo { get; set; }
        public double Bakiye { get; set; }
    }
}
