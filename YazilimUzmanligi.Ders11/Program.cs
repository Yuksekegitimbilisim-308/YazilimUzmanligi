//2 liste olacak.
//1. listede öğrenci isimleri
//2. listede öğrencilik durumları tutulacak.
List<string> ogrenciler = new();
List<bool> durumlar = new();

while (true)
{
    Menu();
    int secenek = int.Parse(Console.ReadLine());
    if (secenek == 5)
    {
        break;
    }
    switch (secenek)
    {
        case 1:
            {
                OgrenciListele(ogrenciler, durumlar);
            }
            break;
        case 2:
            {
                var (inputAd, inputDurum) = OgrenciEkleInput();
                OgrenciEkle(inputAd, inputDurum);
            }
            break;
        case 3:
            {
                var degerler = OgrenciGuncelleInput();
                OgrenciGuncelle(degerler.Item1, degerler.Item2, degerler.Item3);
            }
            break;
        case 4:
            {
                string inputAd = OgrenciSilInput();
                OgrenciSil(inputAd);
            }
            break;
        case 6:
            {
                Console.Clear();

            }
            break;
        default:
            break;
    }

}
void Menu()
{
    Console.WriteLine("1-Öğrencileri Listele");
    Console.WriteLine("2-Öğrenci Ekle");
    Console.WriteLine("3-Öğrenci Güncelle");
    Console.WriteLine("4-Öğrenci Sil");
    Console.WriteLine("5-Programı Bitir");
    Console.WriteLine("6-Konsolu Temizle");
}

void OgrenciListele(List<string> ogrenciler, List<bool> durumlar)
{
    Console.WriteLine();
    for (int i = 0; i < ogrenciler.Count; i++)
    {
        Console.WriteLine($"Öğrenci Adı : {ogrenciler[i]} Öğrencilik Durumu : {durumlar[i]}");
    }
    Console.WriteLine();

}

void OgrenciEkle(string ogrenciAdi, bool durumu)
{
    ogrenciler.Add(ogrenciAdi);
    durumlar.Add(durumu);
    Console.Clear();
}
void OgrenciGuncelle(string eskiAd, string ogreciAdi, bool durumu)
{
    
    int ogrenciIndex = ogrenciler.IndexOf(eskiAd);
    ogrenciler[ogrenciIndex] = ogreciAdi;
    durumlar[ogrenciIndex] = durumu;
    OgrenciListele(ogrenciler, durumlar);

}
void OgrenciSil(string ogrenciAdi)
{
    int ogrenciIndex = ogrenciler.IndexOf(ogrenciAdi);
    ogrenciler.RemoveAt(ogrenciIndex);
    durumlar.RemoveAt(ogrenciIndex);
    OgrenciListele(ogrenciler, durumlar);
}
(string, bool) OgrenciEkleInput()
{
    Console.WriteLine("Lütfen Öğrenci Adı Giriniz.");
    string inputAd = Console.ReadLine();
    Console.WriteLine("Lütfen Öğrencinin Durumunu Giriniz. (true - false)");
    bool inputDurum = bool.Parse(Console.ReadLine());
    return (inputAd, inputDurum);
}
(string, string, bool) OgrenciGuncelleInput()
{
    Console.WriteLine("Güncellemek İstediğiniz Öğrencini Adını Giriniz.");
    string eskiAd = Console.ReadLine();
    Console.WriteLine("Yeni Öğrenci Adını Giriniz.");
    string yeniAd = Console.ReadLine();
    Console.WriteLine("Yeni Durumu Giriniz.(Eskisiyle Aynı Girebilirsiniz.)");
    bool yeniDurum = bool.Parse(Console.ReadLine());
    return (eskiAd, yeniAd, yeniDurum);
}
string OgrenciSilInput()
{
    Console.WriteLine("Lütfen Silmek İstediğiniz Öğrenci Adını Giriniz.");
    string inputAd = Console.ReadLine();
    return inputAd;
}
