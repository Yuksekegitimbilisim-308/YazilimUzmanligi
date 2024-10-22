using YazilimUzmanligi.Ders12._2;

ArabaManager arabaManager = new();

Araba araba1 = new()
{
    MarkaAdi = "Honda",
    ModelAdi = "Accord",
    ModelYili = 2015
};
Araba araba2 = new()
{
    MarkaAdi = "Toyota",
    ModelAdi = "Corolla",
    ModelYili = 2012
};
Araba araba3 = new()
{
    MarkaAdi = "BMW",
    ModelAdi = "3.20D",
    ModelYili = 2019
};
arabaManager.ArabaEkle(araba1);
arabaManager.ArabaEkle(araba2);
arabaManager.ArabaEkle(araba3);

List<Araba> arabalar =  arabaManager.ArabaListele();
foreach (var araba in arabalar)
{
    Console.WriteLine($"Id : {araba.Id} Marka : {araba.MarkaAdi} Model : {araba.ModelAdi} Model Yılı : {araba.ModelYili}");
}
Console.WriteLine("Silmek İstediğiniz Aracın Numarasını Giriniz.");
int id = int.Parse(Console.ReadLine());
arabaManager.ArabaSil(id);
foreach (var araba in arabalar)
{
    Console.WriteLine($"Id : {araba.Id} Marka : {araba.MarkaAdi} Model : {araba.ModelAdi} Model Yılı : {araba.ModelYili}");
}