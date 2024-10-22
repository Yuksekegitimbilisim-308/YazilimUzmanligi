

using YazilimUzmanligi.Ders14;

PersonelYonetim personelYonetim = new ();

var filtre1 = personelYonetim.Filtre1();
var filtre2 = personelYonetim.Filtre2();
var filtre3 = personelYonetim.Filtre3();


Console.WriteLine("Filtre1");
ListeYaz(filtre1);
Console.WriteLine("---------------------------------");
Console.WriteLine("Filtre2");
ListeYaz(filtre2);
Console.WriteLine("---------------------------------");
Console.WriteLine("Filtre3");
ListeYaz(filtre3);
Console.WriteLine("---------------------------------");



void ListeYaz(List<Personel> list)
{
    foreach (var personel in list)
    {
        Console.WriteLine($"Ad Soyad       : {personel.AdSoyad}");
        Console.WriteLine($"Pozisyon       : {personel.Pozisyon}");
        Console.WriteLine($"Maaş           : {personel.Maas}");
        Console.WriteLine($"Çalışma Süresi : {personel.CalismaSuresi}");
    }
}