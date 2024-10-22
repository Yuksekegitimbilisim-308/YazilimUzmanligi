using YazilimUzmanligi.Ders12;

int sayi1 = 5;

List<string> list = new();

Insan insan = new();
insan.Boy = 1.80;
insan.Kilo = 85;
insan.AdSoyad = "Melih Ömer KAMAR";
insan.Yas = 27;
insan.Ad = "Melih";
insan.Soyad = "KAMAR";

Insan insan1 = new();//#asdasd123
insan1.Boy = 1.75;
insan1.Kilo = 75;
insan1.AdSoyad = "Mert";
insan1.Yas = 25;


Console.WriteLine("1. Instance : " + insan.AdSoyad);
Console.WriteLine("2. Instance : " + insan1.AdSoyad);

Insan insan2 = new("Ömer Faruk");
Console.WriteLine("3.Instance (constructor kullanımı) : " + insan2.AdSoyad);

Insan insan3 = new()
{
    AdSoyad = "Ömer Melih KAMAR",
    Boy = 1.50,
    Yas = 25,
    Kilo=65
};

insan.AdSoyadYazdir();


BankaHesabi bankaHesabi = new BankaHesabi();

bankaHesabi.Bakiye = 25;


Sinif1 sinif1 = new(2,"asdahskjf");

sinif1.TestMetot();

BenimSinifim benimSinifim = new();

benimSinifim.Sayi = 5;
benimSinifim.Metin = "";
benimSinifim.test();