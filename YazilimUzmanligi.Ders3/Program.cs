//Operatörler
// + / * -
// (=) değer atama 
// == eşit eşittir
// != eşit değildir
// < küçüktür
// > büyüktür
// <= küçük eşittir
// >= büyük eşittir
// && ve
// || veya 

//Karar yapıları if-else / switch case
//bool kapi = true;


//if (kapi == false)
//{

//}
//else if(kapi == true)
//{

//}
//else if(true)
//{

//}
//else
//{

//}


//int mevcutGun = 3;

//if (mevcutGun == 3)
//{
//    Console.WriteLine("Çarşamba");
//}

string kullaniciAdi = "admin"; 
string sifre = "12345";

//if (kullaniciAdi == "admin" || sifre == "1234")//Şifrenin 1234 değerine eşit olduğunu soruyoruz.
//{
//    Console.WriteLine("Giriş Başarılı.");
//}
//else
//{
//    Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı.");
//}

//if (kullaniciAdi == "admin" || sifre != "1234")//Şifrenin 1234 değerine eşit olmadığını soruyoruz.
//{
//    Console.WriteLine("Giriş Başarılı.");
//}
//else
//{
//    Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı.");
//}

//int sayi1 = 140;
//int sayi2 = 200;
//if (sayi1 < 100)
//{
//    Console.WriteLine($"Sayi1in değeri {sayi1} küçüktür 100den");
//}
//else if (sayi1 > 80)
//{
//    Console.WriteLine($"Sayi1in değeri {sayi1} büyüktür 80den");
//}
//else if (sayi1 > 135)
//{
//    Console.WriteLine($"Sayi1in değeri {sayi1} büyüktür 135");
//}

//if (sayi1 == 150 && sayi2 == 20)
//{
//    Console.WriteLine("İf Bloğu");
//}
//else if (sayi1 >= 80 && sayi2 ==180)
//{
//    Console.WriteLine("1. Else if");
//}
//else if(sayi1 == 150 || sayi2 <=200)
//{
//    Console.WriteLine("2. Else İf");
//}

//int gun = int.Parse(Console.ReadLine());
//if (gun == 1)
//{
//    Console.WriteLine("Pazartesi");
//}
//else if (gun == 2)
//{
//    Console.WriteLine("Salı");
//}
//else if (gun == 3)
//{
//    Console.WriteLine("Çarşamba");
//}
//else if (gun == 4)
//{
//    Console.WriteLine("Perşembe");
//}
//else if (gun == 5)
//{
//    Console.WriteLine("Cuma");
//}
//else if (gun == 6)
//{
//    Console.WriteLine("Cumartesi");
//}
//else if (gun == 7)
//{
//    Console.WriteLine("Pazar");
//}
//else
//{
//    Console.WriteLine("Lütfen Geçeri Bir Gün Giriniz.");
//}

//Kullanıcıdan Ad soyad alınacak 
//Cinsiyet alınacak K E

//kadınsa hoşgeldiniz <adsoyad> hanımefendi
//erkekse hoşgeldiniz <adsoyad> beyefendi 


//Personel
#region Değişkenler
int zamOrani = 0;
double yillikMaas;
double yillikYemek;
double yillikYol;
double toplamGelir;
int vergi = 0;
double netKazanc = 0;
#endregion
#region Kullanıcıdan Alınan Değerler
Console.WriteLine("Lütfen Ad Soyad Giriniz.");
string AdSoyad = Console.ReadLine();
Console.WriteLine("Lütfen Cinsiyet Giriniz.");
string Cinsiyet = Console.ReadLine();
Console.WriteLine("Lütfen Yaş Bilgisi Giriniz.");
int yas = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen Maaş Bilgisi Giriniz.");
double maas = double.Parse(Console.ReadLine());
Console.WriteLine("Lütfen Yol Ücreti Giriniz.");
double yolUcreti = double.Parse(Console.ReadLine());
Console.WriteLine("Lütfen Yemek Ücreti Giriniz.");
double yemekUcreti = double.Parse(Console.ReadLine());
#endregion
//yaş
//maaş
//yol ücreti
//yemek ücreti
//kişi 35 yaşından büyüksa %5 zam alacak
//35 yaşından kucukse %10 zam alacak
//1 yıllık yol ücreti
//1 yıllık yemek ücreti
//1 yıllık zamlı maaş
//ToplamGelir 150000 düşükse %2 yüksekse %5 vergi kesintisi.
//Toplam Gelir.
#region ZamOranı Kararı
if (yas <=35)
{
    zamOrani = 10;
}
else if(yas >35)
{
    zamOrani = 5;
}
#endregion
maas +=  maas * zamOrani / 100;

yillikYol = yolUcreti * 12;
yillikYemek = yemekUcreti * 12;
yillikMaas = maas * 12;
toplamGelir = yillikYol+yillikYemek+yillikMaas;

if (toplamGelir <= 15000)
{
    vergi = 2;   
}
else if(toplamGelir > 150000)
{
    vergi = 5;
}
//net kazanç = 270000 - (270000*5/100) = 13500
netKazanc = toplamGelir - (toplamGelir * vergi / 100);
Console.WriteLine($"Yıllık Toplam Gelir : {toplamGelir}\n");
Console.WriteLine($"Vergi Oranı :{vergi} Vergisi Kesilmiş Gelir : {netKazanc}");


#region Hoşgeldiniz Çıktısı
//if (Cinsiyet == "E" || Cinsiyet == "e")
//{
//    Console.WriteLine($"Hoşgeldiniz {AdSoyad} Beyefendi");
//}
//else if (Cinsiyet == "K" || Cinsiyet == "k")
//{
//    Console.WriteLine($"Hoşgeldiniz {AdSoyad} Hanımefendi");

//}
#endregion

