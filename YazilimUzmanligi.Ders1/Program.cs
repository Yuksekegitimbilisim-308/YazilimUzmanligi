

//Console.WriteLine() Konsola yazı yazdırma komutu.
//Console.WriteLine("Hello, World!");

//Değişkenler,
//(Değişken Tipi) (Değişkenin Adını) = (Değişkenin Değeri)     => Değişken Tanımlama Kalıbı
//Not : Başlarında U olan sayısal değişkenler negatif sayıları alamazlar.

//long _long = 20; //Tam Sayı  444444444444444444444444444444444444444444  16bayt
//ulong _ulong = 0;
//int _int = -15; // Tam Sayı   4444444444444444444444444444444 8bayt
//uint _uint = 0;
//double _double = 15.5; // Ondalıklı Sayı 8bayt  1.444444444444444444444444444444444444 8bayt
//float _float = 15.5f; //Ondalıklı Sayı 4bayt    1.444444444444444444444 4bayt

//bool _bool = true; // True veya False değerler alabilir.

//string _string = "Stringin Değeri"; //Metinsel İfadeler
//char _char = 'A';

//string metin = "metin1", metin2 = "metin2", metin3 = "metin3";

//int sayi1 = 0, sayi2 = 1, sayi3 = 2;

//string kursAdi = "Yüksek Bilişim Akademi";

//int kdv = 20;

//Console.WriteLine(kursAdi);
//Console.WriteLine(kursAdi);
//Console.WriteLine(kursAdi);
//Console.WriteLine(kursAdi);
//Console.WriteLine(kursAdi);
//Console.WriteLine(kursAdi);
//Console.WriteLine(kursAdi);
//Console.WriteLine(kursAdi);

//string Ad = "Melih Ömer";
//string Soyad = "Kamar";
//int yas = 27;
//string bosluk = " ";
//Console.WriteLine(Ad+" "+Soyad+" "+yas);
//Console.WriteLine($"Adınız : {Ad}  Soyadınız : {Soyad}  Yaşınız :  {yas}");


//int sayi = 79;
//int sayi1 = 28;
//int sayi3 = 50;



//int toplam = sayi + sayi1 + sayi3;
//int fark = sayi - sayi1 - sayi3;
//int carpim = sayi * sayi1 * sayi3;
//int bolme = sayi / sayi1 * sayi3;

//Console.WriteLine($"Sayı Ve Sayı1 Değişkenlerinin Toplamları : {toplam}");
//Console.WriteLine($"Sayı Ve Sayı1 Değişkenlerinin Farkları : {fark}");
//Console.WriteLine($"Sayı Ve Sayı1 Değişkenlerinin Çarpımları : {carpim}");
//Console.WriteLine($"Sayı Ve Sayı1 Değişkenlerinin Bölümleri : {bolme}"); 

//float maas = 145.50f;

//+-/* (+=) (-=)

string AdSoyad = "Melih Ömer KAMAR";
int yas = 27;
double maas = 145.5;
int yuzdeOran = 10;
int vergiOrani = 5;
bool aktifMi = true;
//dsjfjk342#    145.5  + 145.5 * 10 / 100; 
//maas =  maas + maas * 10 / 100;

Console.WriteLine($"Eski Maaş : {maas}");
maas +=  maas * yuzdeOran / 100;
Console.WriteLine($"Güncel Maaş : {maas} || Maaş Zam Oranı : {yuzdeOran}");

double BrutYillikMaas = maas * 12;
double netYillikMaas;

double vergisi = BrutYillikMaas * vergiOrani / 100;
netYillikMaas = BrutYillikMaas - vergisi;

//decimal maas1 = 14.50m;
double gunlukYolParasi = 1.40;
double yillikYolParasi = gunlukYolParasi * 365;
double MaasVeYolParasi = netYillikMaas + yillikYolParasi;

double gunlukYemekParasi = 12.50;
double yillikYemekParasi = gunlukYemekParasi * 365;
double MaasVeYemekParasi = netYillikMaas + yillikYemekParasi;

double PersonelYillikMaliyet = netYillikMaas + yillikYolParasi + yillikYemekParasi;


Console.WriteLine($"Brüt Yıllık Maaş : {BrutYillikMaas}");
Console.WriteLine($"Vergi Oranı : {vergiOrani}   ||  Maaştan Düşülen Vergi Tutarı : {vergisi}");
Console.WriteLine($"Net Ödenecek Maaş Tutarı : {netYillikMaas}");
Console.WriteLine($"Yıllık Yol Parası :  {yillikYolParasi}");
Console.WriteLine($"Yıllık Maaş + Yol Parası Maliyet : {MaasVeYolParasi}");
Console.WriteLine($"Yıllık Yemek Parası : {yillikYemekParasi}");
Console.WriteLine($"Yıllık Maaş + Yemek Parası : {MaasVeYemekParasi}");

Console.WriteLine($"Personelin Yıllık Maaliyeti : {PersonelYillikMaliyet}");


