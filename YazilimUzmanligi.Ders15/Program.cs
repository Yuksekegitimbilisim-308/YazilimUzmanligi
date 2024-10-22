//Hesap = class
//Id
//AdSoyad
//HesapNo = int
//Bakiye
using System.Xml.Serialization;
using YazilimUzmanligi.Ders15;

Random _random = new Random();
int rastgeleSayi = _random.Next(10000);

//HesapYonetim = class
//List<Hesap>
//HesapGetir
//HesaplarıGetir
//HesapEkle
//HesapGüncelle = sadece adsoyad
//HesapSil
//ParaCekme
//ParaGonderme
//ParaYatırma
//SeedData
HesapYonetim hesapYonetim = new(1);

//HesaplariListele();
//HesapGetir(3);
HesapGetir(1);
HesapGetir(4);
ParaGonder(499, 4);
HesapGetir(1);
HesapGetir(4);


void ParaYatirma(double para)
{
    hesapYonetim.ParaYatirma(para);
}
void ParaGonder(double para,int aliciId)
{
    hesapYonetim.ParaGonder(aliciId, para);
}
void HesaplariListele()
{
   var list = hesapYonetim.HesapListesiGetir();
    foreach (var hesap in list)
    {
        Console.WriteLine($"Id        : {hesap.Id}");
        Console.WriteLine($"Hesap No  : {hesap.HesapNo}");
        Console.WriteLine($"Ad Soyad  : {hesap.AdSoyad}");
        Console.WriteLine($"Bakiye    : {hesap.Bakiye}");
        Console.WriteLine("-------------------------------");
    }
}
void HesapGetir(int id)
{
    var hesap = hesapYonetim.HesapGetir(id);
    Console.WriteLine("-------------------------------");
    Console.WriteLine($"Id        : {hesap.Id}");
    Console.WriteLine($"Hesap No  : {hesap.HesapNo}");
    Console.WriteLine($"Ad Soyad  : {hesap.AdSoyad}");
    Console.WriteLine($"Bakiye    : {hesap.Bakiye}");
    Console.WriteLine("-------------------------------");
}
void HesapEkle()
{

    Hesap hesap = new() {AdSoyad = "Habibe ÇINAR",Bakiye = 543 };
    hesapYonetim.HesapEkle(hesap);
}