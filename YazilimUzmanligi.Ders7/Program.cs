//List<string> isimler  = new List<string>();
//List<string> isimler = new();

//isimler.Add("Melih");
//isimler.Add("Mert");
//isimler.Add("Doğuş");
//isimler.Add("Ömer Faruk");
//isimler.Add("Abdullah");


//foreach (var isim in isimler)
//{

//}

//for (int i = 0; i < isimler.Count; i++)
//{
//}
//List<string> isimler  = new List<string>();
//List<string> isimler = new();

//2 liste olucak
//1. liste alışveriş listesi
//2. liste fiyatların listesi
//elemanlar kullanıcıdan input olarak alınacak.
//kullanıcı alışveriş listesine 'x' değeri verirse fiyat sormadan listelerin ekleme işlemi biticek.
//ve ekrana listedeki ürünlerin isimlerini ve fiyatlarını yazıcak.
using System;

List<string>  listem = new List<string>();
List<double>  fiyatlarim = new();
while (true)
{
    Console.WriteLine("Lütfen Alışveriş Listesine Ürün Adı Ekleyiniz.");
    string urunAdi = Console.ReadLine();
    if (urunAdi == "x")
    {
        break;
    }
    listem.Add(urunAdi);
    Console.WriteLine($"Lütfen {urunAdi} Fiyatını Giriniz.");
    double fiyat = double.Parse(Console.ReadLine());
    fiyatlarim.Add(fiyat);
}
Console.Clear();
double toplamFiyat = 0;
for (int i = 0; i < listem.Count; i++)
{
    Console.WriteLine($"{i+1}. Ürün : {listem[i]} Fiyatı : {fiyatlarim[i]}");
    toplamFiyat += fiyatlarim[i];
}
Console.WriteLine($"Alışveriş Sepetinizde Toplam : {listem.Count}");
Console.WriteLine($"Alışveriş Sepeti İçin Ödenecek Tutar : {toplamFiyat}");



Console.WriteLine("Alışveriş Sepetinden Ürün Silmek Veya Güncellemek İstermisiniz.");
Console.WriteLine("-Silmek için 1 tuşlayabilirsiniz.");
Console.WriteLine("-Güncellemek için 2 tuşlayabilirsiniz.");
string secenek = Console.ReadLine();
if (secenek == "1")
{
    Console.WriteLine("Silmek İstediğiniz Ürünün Adını Giriniz.");
    string silinecekUrun = Console.ReadLine();
    if (listem.Contains(silinecekUrun))
    {
        int silinecekIndex =  listem.IndexOf(silinecekUrun);
        listem.RemoveAt(silinecekIndex);
        fiyatlarim.RemoveAt(silinecekIndex);
        Console.Clear();
        for (int i = 0;  i < fiyatlarim.Count;  i++)
        {
            Console.WriteLine($"{i + 1}. Ürün : {listem[i]} Fiyatı : {fiyatlarim[i]}");
        }
        Console.WriteLine($"Alışveriş Sepetinizde Toplam : {listem.Count} Ürün Bulunmaktadır.");
        Console.WriteLine($"Alışveriş Sepeti İçin Ödenecek Tutar : {fiyatlarim.Sum()}");
    }
}
else if(secenek == "2")
{
    Console.WriteLine("-Ürünün Adını Güncellemek İçin 1'i tuşlayınız.");
    Console.WriteLine("-Ürünün Fiyatı Güncellemek İçin 2'i tuşlayınız.");
    Console.WriteLine("-Ürünün Fiyatı Ve Adını Güncellemek İçin 3'ü tuşlayınız.");
    string guncellemeSecenegi = Console.ReadLine();
    if (guncellemeSecenegi == "1")
    {
        Console.WriteLine("Güncellenecek Ürün Adını Giriniz.");
        string guncellenecekUrun = Console.ReadLine();
        if (listem.Contains(guncellenecekUrun))
        {
            int guncellenecekIndex = listem.IndexOf(guncellenecekUrun);
            Console.WriteLine($"({listem[guncellenecekIndex]}) Yeni Adını Giriniz.");
            string yeniUrun = Console.ReadLine();
            listem[guncellenecekIndex] = yeniUrun;
            Console.Clear();
            for (int i = 0; i < listem.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Ürün : {listem[i]} Fiyatı : {fiyatlarim[i]}");
            }
            Console.WriteLine($"Alışveriş Sepetinizde Toplam : {listem.Count} Ürün Bulunmaktadır.");
            Console.WriteLine($"Alışveriş Sepeti İçin Ödenecek Tutar : {fiyatlarim.Sum()}");

        }
    }
    else if(guncellemeSecenegi == "2")
    {
        Console.WriteLine("Güncellenecek Ürün Adını Giriniz.");
        string guncellenecekUrunAdi = Console.ReadLine();
        if (listem.Contains(guncellenecekUrunAdi))
        {
            int guncellenecekIndex = listem.IndexOf(guncellenecekUrunAdi);
            Console.WriteLine($"{listem[guncellenecekIndex]} Ürününü Fiyatı : {fiyatlarim[guncellenecekIndex]} => Yeni Fiyatı Giriniz.");
            double guncelFiyat = double.Parse(Console.ReadLine());
            fiyatlarim[guncellenecekIndex] = guncelFiyat;
            Console.Clear();
            for (int i = 0; i < listem.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Ürün : {listem[i]} Fiyatı : {fiyatlarim[i]}");
            }
            Console.WriteLine($"Alışveriş Sepetinizde Toplam : {listem.Count} Ürün Bulunmaktadır.");
            Console.WriteLine($"Alışveriş Sepeti İçin Ödenecek Tutar : {fiyatlarim.Sum()}");
        }
        
    }
    else if (guncellemeSecenegi == "3")
    {
        Console.WriteLine("Güncellenecek Ürünün Adını Giriniz.");
        string guncellenecekkUrunAdi = Console.ReadLine();
        if (listem.Contains(guncellenecekkUrunAdi))
        {
            int index = listem.IndexOf(guncellenecekkUrunAdi);
            Console.WriteLine($"{listem[index]} Ürününün Yeni Adını Giriniz.");
            string yeniAdi = Console.ReadLine();
            Console.WriteLine($"{listem[index]} Fiyatı : {fiyatlarim[index]} Yeni Fiyatını Giriniz.");
            double yeniFiyat = double.Parse(Console.ReadLine());
            string urunEskiAdi = listem[index];
            double eskiFiyat = fiyatlarim[index];
            listem[index] = yeniAdi;
            fiyatlarim[index] = yeniFiyat;
            Console.Clear();
            Console.WriteLine($"{urunEskiAdi} => {yeniAdi}");
            Console.WriteLine($"{eskiFiyat} => {yeniFiyat}");
            for (int i = 0; i < listem.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Ürün : {listem[i]} Fiyatı : {fiyatlarim[i]}");
            }
            Console.WriteLine($"Alışveriş Sepetinizde Toplam : {listem.Count} Ürün Bulunmaktadır.");
            Console.WriteLine($"Alışveriş Sepeti İçin Ödenecek Tutar : {fiyatlarim.Sum()}");
        }
    }

}
//Alışveriş Listesinde Kaç ürün olduğu
//ve listenin toplam fiyatları yazdırılacak.
