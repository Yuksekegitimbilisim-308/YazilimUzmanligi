
#region Döngüler
//for (int i = 0; i < 3; i++)
//{
//    i = i + 1;
//    i++;
//    i += 1;
//    Console.WriteLine($"Döngü {i+1}.Turunda");
//}

//string dbKullaniciAdi = "admin";
//string dbSifre = "admin123";
//int girisDeneme = 3;
//for (int i = 0; i < girisDeneme; i++)
//{
//    Console.WriteLine("Kullanıcı Adı Giriniz.");
//    string kullaniciAdi = Console.ReadLine();
//    Console.WriteLine("Şifrenizi Giriniz.");
//    string sifre = Console.ReadLine();

//    if (dbKullaniciAdi == kullaniciAdi && dbSifre == sifre)
//    {
//        Console.WriteLine("Giriş Başarılı.");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Giriş Başarısız.");
//    }
//}

#endregion
//Koleksiyonlar
//Diziler - Listeler
//Koleksiyonlar bir yapı içerisinde birden fazla değişken gibi değer tutmamıza yarayan yapılarıdır. Kullanım amacı bir değişken listesi oluşturmaya benzer.

//(veri tipi[]) (dizi adı) = new (veri tipi[dizi kapasitesi]);
//(veri tipi[]) (dizi adı) = {1,2,3,4,5};
//string[] isimler = new string[6];
//string[] isimler2 = { "Mert", "Batuhan", "Doğuş", "Abdurrahman", "Abdullah", "Ömer Faruk", "Melih" };


//isimler[0] = "Mert";
//isimler[1] = "Batuhan";
//isimler[2] = "Doğuş";
//isimler[3] = "Abdurrahman";
//isimler[4] = "Abdullah";
//isimler[5] = "Ömer Faruk";
//for (int i = 0; i < isimler2.Length; i++)
//{
//    if (yaslar[i] >= 18)
//    {
//        Console.WriteLine($"Adınız :  {isimler2[i]} Yaşınız : {yaslar[i]}");
//    }
//}
//int[] yaslar = {25,17,38,18,14,10,26 };
//Console.WriteLine("\nDizinin Tanımlanma Sırası \n");
//for (int i = 0; i < yaslar.Length; i++)
//{
//    Console.WriteLine(yaslar[i]);
//}
//Console.WriteLine("\nMevcut Dizinin Reverse Edilmiş Hali. \n");
//Array.Reverse(yaslar); // Mevcut Dizi Durumunun Ters Sıralanmış Hali.
//for (int i = 0; i < yaslar.Length; i++)
//{
//    Console.WriteLine(yaslar[i]);
//}
//Array.Sort(yaslar);//Dizi Elemanlarını Eğer sayısal değerler ise küçükten büyüğe sıralar.
////Metinsel Değerler tutan bir dizi ise A-Z sıralar.
//Console.WriteLine("\nKüçükten Büyüğe Sıralanmış Hali \n");
//for (int i = 0; i < yaslar.Length; i++)
//{
//    Console.WriteLine(yaslar[i]);
//}
//Array.Reverse(yaslar);//Mevcut Dizi Durumunun Ters Sıralanmış Hali. (Bir üstteki blokta küçükten büyüğe sıralandığı için büyükten küçüğe sıralanmış oldu.)
//Console.WriteLine("\nTerse Sıralanmış Hali \n");
//for (int i = 0; i < yaslar.Length; i++)
//{
//    Console.WriteLine(yaslar[i]);
//}
//3 farklı dizi oluşturalacak.
//1. dizi çalışan isimlerini string
//2. dizi çalışanların kaç aydır çalıştıklarını. int
//3. dizi çalışanların aylık maaşlarını tutucak. double

//dizilerin değerlerini döngü içerisinde istemelisiniz.
//her dizinini değerleri verildikten sonra başka bir döngü ile 
// çalışan adı : {adı} maaşı : {maas} çalştığı ay : {calistigiAy}
//şeklinde console yazdırılması gerekiyor.

//string[] calisanlar = new string[3];
//int[] calistigiSure = new int[3];
//double[] maaslar = new double[3];
//for (int i = 0; i < calisanlar.Length; i++)
//{
//    Console.WriteLine("Çalışan Adını Giriniz.");
//    string calisanAdi = Console.ReadLine();
//    Console.WriteLine("Çalışanın Maaşını Giriniz.");
//    double calisanMaas = double.Parse(Console.ReadLine());
//    Console.WriteLine("Çalışanın Çalıştığı Süreyi Giriniz.");
//    int calisanSure = int.Parse(Console.ReadLine());

//    calisanlar[i] = calisanAdi;
//    maaslar[i] = calisanMaas;
//    calistigiSure[i] = calisanSure;
//}
//Console.Clear();
//for (int i = 0; i < maaslar.Length; i++)
//{
//    Console.WriteLine($"Çalışanın Adı : {calisanlar[i]} | Çalışanın Maaşı : {maaslar[i]} | Çalıştığı Süre : {calistigiSure[i]}");
//}
//Console.WriteLine("Kaç Elemanlı Dizi Oluşturulsun ? ");
//int diziBoyutu = int.Parse(Console.ReadLine());
//int[] degerler = new int[diziBoyutu];
//Restoran uygulaması
//3 dizi olucak
//1. dizi yemeğin adını string
//2. dizi yemeğin fiyatını double
//3. dizi yemeğin satış adedi int
//Consolda yemek adı  : {yemekadi} yemek fiyat: {fiyat} satış adedi : {satisAdedi} => Toplam Gelir : {fiyat*satisAdedi}

Console.WriteLine("Kaç Yemek Satışı Giriceksiniz ?  ");
int diziBoyutu = int.Parse(Console.ReadLine());

string[] Yemekler = new string[diziBoyutu];
double[] Fiyatlar = new double[diziBoyutu];
int[] Satislar = new int[diziBoyutu];
int toplamSatilanYemek = 0;
double toplamKazanc = 0;

for (int i = 0; i < Yemekler.Length; i++)
{
    Console.WriteLine("Yemek Adını Giriniz.");
    Yemekler[i] = Console.ReadLine();
    Console.WriteLine("Fiyatını Giriniz.");
    Fiyatlar[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Satış Adedini Giriniz.");
    Satislar[i] = int.Parse(Console.ReadLine());
}
Console.Clear();
for (int i = 0; i < Fiyatlar.Length; i++)
{
    toplamSatilanYemek += Satislar[i];
    toplamKazanc += Fiyatlar[i] * Satislar[i];
    Console.WriteLine($"Yemek Adı : {Yemekler[i]}\nFiyatı : {Fiyatlar[i]}\nSatış Adedi : {Satislar[i]}\nÜründen Gelen Toplam Kazanç : {Fiyatlar[i] * Satislar[i]}\n");
}
Console.WriteLine("Restoran Z Raporu \n");
Console.WriteLine($"Toplam Kazanç  :{toplamKazanc}");
Console.WriteLine($"Toplam Satış Adedi  :{toplamSatilanYemek}");