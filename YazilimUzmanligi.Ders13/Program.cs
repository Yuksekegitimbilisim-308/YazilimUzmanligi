using YazilimUzmanligi.Ders13;



HesapBilgileriYonetim hesapBilgileriYonetim = new();

var hesaplar =  hesapBilgileriYonetim.HesaplariGetir();


//Kullanıcıdan inputlar alınacak
//Alınan inputlar ile yeni bir HesapBilgileri nesnesi oluşturulucak. Constructor üzerinden değerler gönderilecek.
//Yonetim sınıfının içerisindeki ekleme metodumuz çağırılacak parametre olarak oluşturduğum HesapBilgiler nesnesi verilecek.
HesaplariListele();
HesapBilgisiEkle();
HesapBilgisiGuncelle();
HesapBilgisiSil();

void HesapBilgisiEkle()
{
    Console.WriteLine("Ad Soyad Giriniz.");
    string adSoyad = Console.ReadLine();
    Console.WriteLine("Hesap No Giriniz.");
    int hesapNo = int.Parse(Console.ReadLine());
    Console.WriteLine("Bakiye Miktarı Giriniz.");
    double bakiye = double.Parse(Console.ReadLine());
    HesapBilgileri hesapBilgileri = new(adSoyad,hesapNo,bakiye);
    hesapBilgileriYonetim.HesapBilgisiEkle(hesapBilgileri);
    HesaplariListele();
}
void HesapBilgisiSil()
{
    Console.WriteLine("Silinecek Id giriniz.");
    int Id = int.Parse(Console.ReadLine());
    hesapBilgileriYonetim.HesapBilgisiSil(Id);
    HesaplariListele();

}
void HesapBilgisiGuncelle()
{
    Console.WriteLine("Güncellenecek Hesap Id Giriniz.");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Yeni Bakiyeyi Giriniz.");
    double bakiye = double.Parse(Console.ReadLine());
    HesapBilgileri hesapBilgileri = new() {Id = id,Bakiye = bakiye };
    hesapBilgileriYonetim.HesapBilgisiGuncelle(hesapBilgileri);
    HesaplariListele();

}
void HesaplariListele()
{
    Console.Clear();
    foreach (var hesap in hesaplar)
    {
        Console.WriteLine($"Hesap SıraNo   : {hesap.Id}");
        Console.WriteLine($"Hesap Numarası : {hesap.HesapNo}");
        Console.WriteLine($"Hesap Sahibi   : {hesap.AdSoyad}");
        Console.WriteLine($"Hesap Bakiyesi : {hesap.Bakiye}");
        Console.WriteLine("-----------------------------------------------------");
    }

}