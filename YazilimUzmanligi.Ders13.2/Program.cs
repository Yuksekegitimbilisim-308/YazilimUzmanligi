using System.Collections.Generic;
using YazilimUzmanligi.Ders13._2;

OgrenciYonetim ogrenciYonetim = new OgrenciYonetim();


while (true)
{
    Menu();
    int input = int.Parse(Console.ReadLine());
    if (input == 10)
    {
        break;
    }
    switch (input)
    {
        case 1:
            OgrenciListesi();
            break;
        case 2:
            OgrenciEkle();
            break;
        case 3:
            OgrenciGuncelle();
            break;
        case 4:
            OgrenciSil();
            break;
        case 5:
            OgrenciGetir();
            break;
        case 6:
            SinifaGoreOgrenciListesi();
            break;
        case 7:
            AktifOgrenciler();
            break;
        case 8:
            OgrenciAdiFiltre();
            break;
        case 9:
            SinifVeDurumArama();
            break;
        case 15:
            EkraniTemizle();
            break;
        default:
            break;
    }
}

void Menu()
{
    Console.WriteLine("1- Öğrencileri Listele.");
    Console.WriteLine("2- Öğrenci Ekle.");
    Console.WriteLine("3- Öğrenci Güncelle.");
    Console.WriteLine("4- Öğrenci Sil.");
    Console.WriteLine("5- Bir Öğrenci Getir.");
    Console.WriteLine("6- Sınıfa Göre Filtreleme.");
    Console.WriteLine("7- Aktif Öğrencileri Getir.");
    Console.WriteLine("8- Verilen İsme Göre Öğrencileri Getirme.");
    Console.WriteLine("9- Sınıf Ve Duruma Göre Arama Yap.");
    Console.WriteLine("10- Programı Bitir.");
    Console.WriteLine("15- Ekranı Temizle.");
}


void SinifVeDurumArama()
{
    Console.Clear();
    Console.WriteLine("Lütfen Arayacağınız Sınıfı Giriniz.");
    int sinif = int.Parse(Console.ReadLine());
    Console.WriteLine($"{sinif} Sınıfındaki Hangi Durumdaki Öğrencileri Görmek İstiyorsunuz. (true / false)");
    bool durum = bool.Parse(Console.ReadLine());
    var list = ogrenciYonetim.SinifVeDurumaGoreFiltre(sinif, durum);
    OgrenciListe(list);
}
void OgrenciAdiFiltre()
{
    Console.Clear();
    Console.WriteLine("Aramak İstediğiniz Öğrenci Adını Giriniz.");
    string input = Console.ReadLine();
    var list = ogrenciYonetim.IsimSoyisimArama(input);
    OgrenciListe(list);
}
void AktifOgrenciler()
{
    Console.Clear();
    var list = ogrenciYonetim.AktifOgrencilerinListesi();
    OgrenciListe(list);
}
void SinifaGoreOgrenciListesi()
{
    Console.Clear();
    Console.WriteLine("Lütfen Filtremek istediğiniz sınıfı Giriniz.");
    int sinif = int.Parse(Console.ReadLine());
    var list = ogrenciYonetim.SinifaGoreOgrenciler(sinif);
    OgrenciListe(list);
}
void OgrenciGetir()
{
    Console.Clear();
    Console.WriteLine("Getirmek İstediğiniz Öğrenci Id Giriniz.");
    int input = int.Parse(Console.ReadLine());
    Ogrenci ogrenci = ogrenciYonetim.OgrenciGetir(input);
    Console.WriteLine($"Öğrenci ID        : {ogrenci.Id}");
    Console.WriteLine($"Ad Soyad          : {ogrenci.AdSoyad}");
    Console.WriteLine($"Sınıfı            : {ogrenci.Sinif}");
    Console.WriteLine($"Öğrencilik Durumu : {ogrenci.Durumu}");
    Console.WriteLine("---------------------------------------");

}
void OgrenciSil()
{
    Console.Clear();
    Console.WriteLine("Silinecek Öğreni Id Giriniz.");
    int input = int.Parse(Console.ReadLine());
    ogrenciYonetim.OgrenciSil(input);
    Console.Clear();
}
void OgrenciGuncelle()
{
    Console.Clear();
    Console.WriteLine("Güncellenecek Öğrenci Id sini Giriniz.");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Yeni Ad Soyad Giriniz.");
    string adSoyad = Console.ReadLine();
    Console.WriteLine("Yeni Sınıfını Giriniz.");
    int sinif = int.Parse(Console.ReadLine());
    Console.WriteLine("Yeni Durumu.");
    bool durum = bool.Parse(Console.ReadLine());
    Ogrenci ogrenci = new() { Id = id, AdSoyad = adSoyad, Durumu = durum, Sinif = sinif };
    ogrenciYonetim.OgrenciGuncelle(ogrenci);
    Console.Clear();
}
void OgrenciEkle()
{
    Console.Clear();
    Console.WriteLine("Öğrenci Ad Soyad Giriniz.");
    string adSoyad = Console.ReadLine();
    Console.WriteLine("Öğrencinin Sınıfını Giriniz.");
    int sinif = int.Parse(Console.ReadLine());
    Console.WriteLine("Öğrenci Aktif mi ?");
    bool durum = bool.Parse(Console.ReadLine());
    Ogrenci ogrenci = new() { AdSoyad = adSoyad, Sinif = sinif, Durumu = durum };
    ogrenciYonetim.OgrenciEkle(ogrenci);
    Console.Clear();
}
void OgrenciListesi()
{
    Console.Clear();
    var list = ogrenciYonetim.OgrenciListele();
    OgrenciListe(list);
}

void OgrenciListe(List<Ogrenci> list)
{
    foreach (var ogrenci in list)
    {
        Console.WriteLine($"Öğrenci ID        : {ogrenci.Id}");
        Console.WriteLine($"Ad Soyad          : {ogrenci.AdSoyad}");
        Console.WriteLine($"Sınıfı            : {ogrenci.Sinif}");
        Console.WriteLine($"Öğrencilik Durumu : {ogrenci.Durumu}");
        Console.WriteLine("---------------------------------------");
    }
}

void EkraniTemizle()
{
    Console.Clear();
}