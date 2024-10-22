namespace YazilimUzmanligi.Ders12
{
    public class Insan
    {
        public Insan(string paramAdSoyad)
        {
            AdSoyad = paramAdSoyad;
        }
        public Insan()
        {

        }
        //En küçük yapısı Properties - Field
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string AdSoyad { get; set; }
        private string SacRengi { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad Soyad : {Ad} {Soyad}");
        }
    }
}