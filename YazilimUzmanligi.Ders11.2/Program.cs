//Hesap Bakiyesi olucak
//Menu olucak
//Menude para gönder - para çek - para yatır - Hesabı Kontrol Et 
//Bir liste olucak para gönderilecek kişilerin isimlerinin olduğu.
//Para gönder seçeneğinde o isimlerden birini seçicez.
//Yapılan her işlemde bir string yazılacak. Formatlı örnegin mevcut bakiye işlem türü yatırılacak tutar ve güncel bakiye.
//bir liste içerisinde ekleme yapılacak.
//menudeki yeni seçenekten bu liste ekrana bastırılacak.
double Bakiye = 500;
List<string> kisiler = new() { "Melih", "Habibe", "Ömer Faruk", "Abdullah", "Batuhan" };
List<string> hesapOzeti = new();
while (true)
{
    HesapKontrol();
    Menu();
    int secenek = int.Parse(Console.ReadLine());
    if (secenek == 6)
    {
        break;
    }
    
    switch (secenek)
    {
        case 1:
            {
                ParaYatir();
            }
            break;
        case 2:
            {
                ParaCek();
            }
            break;
        case 3:
            {
                ParaGonder();
            }
            break;
        case 4:
            {
                HesapKontrol();
            }
            break;
        case 5:
            {
                HesapOzetiListele();
            }
            break;
        default:
            break;
    }
}



void Menu()
{
    Console.WriteLine("1- Para Yatır.");
    Console.WriteLine("2- Para Çek.");
    Console.WriteLine("3- Para Gönder.");
    Console.WriteLine("4- Bakiye Sorgula.");
    Console.WriteLine("5- Hesap Özeti Göster");
    Console.WriteLine("6- Atm Programı Bitir.");
}
void ParaYatir()
{
    Console.WriteLine("Yatırmak İstediğiniz Miktarı Giriniz.");
    double miktar = double.Parse(Console.ReadLine());
    Bakiye += miktar;
    HesapOzetiEkle($"Para Girişi : {miktar} Güncel Tutar : {Bakiye}");
}
void ParaCek()
{
    Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz.");
    double miktar = double.Parse(Console.ReadLine());
    if (Bakiye >= miktar)
    {

        Bakiye -= miktar;
        HesapOzetiEkle($"Para Çıkışı : {miktar} Güncel Tutar : {Bakiye}");

    }
}
void ParaGonder()
{
    Console.WriteLine("Gönder İstediğiniz Miktarı Giriniz.");
    double miktar = double.Parse(Console.ReadLine());
    if (Bakiye >= miktar)
    {
        Console.WriteLine("Göndermek İstediğiniz Kişiyi Giriniz.");
        KisiListesi();
         int index = int.Parse(Console.ReadLine());
        if (index <=  (kisiler.Count-1))
        {
            Bakiye -= miktar;
            HesapOzetiEkle($"Para Gönderme İşlemi : {miktar} Güncel Tutar : {Bakiye}");

        }

    }
}
void HesapKontrol()
{
    Console.WriteLine($"Mevcut Hesap Bakiyeniz : {Bakiye}");
}
void KisiListesi()
{
    for (int i = 0; i < kisiler.Count; i++)
    {
        Console.WriteLine($"index = {i} Ad Soyad = {kisiler[i]}");
    }
}
void HesapOzetiListele()
{
    var list = hesapOzeti.OrderByDescending(x => x);
    foreach (var mesaj in list)
    {
        Console.WriteLine(mesaj);
    }
}
void HesapOzetiEkle(string paramMesaj)
{
    int sayi = hesapOzeti.Count +1;
    string mesaj = $"{sayi} - {paramMesaj}";
    hesapOzeti.Add(mesaj);
}