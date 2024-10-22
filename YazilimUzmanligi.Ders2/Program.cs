
//Değişkenler
//Sayısal
//byte 0-256 
///ubyte 
//int tam sayılar 100000000000000000000000000000000000 -5000
//uint 
//double ondalıklı sayılar  1.000000000000000000000000000
//float ondalıklı sayılar   1.000000000000000000f
//decimal ondalıklı sayılar 1.00000000000000000000000000000000000m
//long -500000000000 - 500000000000
//ulong 5000000000050000000000
//(değişken veri tipi) (değişken adı) = (değiken değeri)
//değişken tanımlanırken başına const keyword koyulduğunda sadece tanımlandığı noktada değer 
//atanabilir değeri daha sonra değiştirilemez.
int sayi = -15;
int sayi1;
//birden fazla aynı tipte değişken tanımlama yöntemi.
int sayi2 = 1,sayi3 = 2,sayi4 = 3,sayi5,sayi6;
//birden fazla değişken tanımlama
int sayi12 = 0;
int sayi13 = 0;
int sayi14 = 0;


double sayi7 = 1;
float sayi8 = 1.2f;

byte sayi9 = 10;
uint sayi10 = 11;
//Metinsel
//string metinsel değerler alabilir. " " arasına değerlerini yazarız.
//char sadece bir karakter değer alabilir. değerini ' ' arasına yazmalıyız.
string metin = "ben string değişkeninin değeriyim.";
char karakter = 'A';

//
//bool sadece true veya false şeklinde değerler alabiliyor. Doğru Yanlış, Evet Hayır, Kapalı Açık
bool dogruYanlis = false;
bool yanlisDogru = true;

sayi7 = 1.24;
yanlisDogru = false;


//int _int = 15;
//Console.WriteLine(_int);

//_int = 20;

//Console.WriteLine(_int);

//_int = 25;
//Console.WriteLine(_int);

//const int kdv = 20;
//string Ad = "Melih Ömer";
//string Soyad = "KAMAR";
//int yas = 27;
//Console.WriteLine($"Ad : {Ad} Soyad :  {Soyad} Yaş :  {yas}");
//Console.WriteLine($"Ad: {Ad}");
//Console.WriteLine($"Soyad : {Soyad}");
//Console.WriteLine($"Yaş : {yas}");

//Console.WriteLine($"Adınız : {Ad} \nSoyadınız : {Soyad} \nYaş : {yas}");


//bir kişi oluşturun 
//adı
//soyadı
//yaşı
//calıstıgı yer
//egitim gördügü yer
//maas
//burs 

//Gider

//kira
//mutfak ücreti
//yol ücreti
//diğer giderler

//aylık maas ve burs toplanıcak. yeni bir değişkene ata
//giderler toplanıcak.  yeni bir değişkene ata
//Console aradaki fark yazdırılıcak. Gelir ve Giderden kalan fark.
//I/O Input - Output
//Console.WriteLine("Adınızı Giriniz.");
//string Isim = Console.ReadLine();
//Console.WriteLine("Soyadınızı Giriniz.");
//string Soyisim = Console.ReadLine();
//Console.WriteLine("Yaşınızı Giriniz. (Sadece Sayısal Değer Giriniz.)");
//int yas = int.Parse(Console.ReadLine());
//Console.WriteLine("Çalıştığınız Kurum Adını Giriniz.");
//string calistigiYer = Console.ReadLine();
//Console.WriteLine("Eğitim Kurumunuzu Giriniz.");
//string egitimGorduguYer = Console.ReadLine();



////Gelirlerim
//Console.WriteLine("Maaş Gelirinizi Giriniz.");
//double maas = double.Parse(Console.ReadLine());
//Console.WriteLine("Burs Gelirinizi Giriniz.");
//double burs = double.Parse(Console.ReadLine());

//double Gelirler = maas + burs;

////Giderlerim
//Console.WriteLine("Kira Giderinizi Giriniz.");
//double kira = double.Parse(Console.ReadLine());
//Console.WriteLine("Mutfak Giderlerinizi Giriniz.");
//double mutfakMasrafi = double.Parse(Console.ReadLine());
//Console.WriteLine("Yol Giderlerinizi Giriniz.");
//double yolMasrafi = double.Parse(Console.ReadLine());
//Console.WriteLine("Diğer Giderlerinizi Giriniz.");
//double digerGiderler = double.Parse(Console.ReadLine());
//Console.Clear();

//double Giderler = kira + mutfakMasrafi + yolMasrafi + digerGiderler;

//Console.WriteLine("Kişi Bilgileri...");
//Console.WriteLine($"Ad : {Isim} Soyad : {Soyisim} Yaş : {yas} Çalıştığı Yer : {calistigiYer}");
//Console.WriteLine("Gelirler");
//Console.WriteLine($"Maaş : {maas}, Burs : {burs}");
//Console.WriteLine($"1.Aylık Gelir Toplamı : {Gelirler}");
//Console.WriteLine("Giderler");
//Console.WriteLine($"Kira : {kira}, Mutfak Masrafı : {mutfakMasrafi}, Yol Masrafı : {yolMasrafi}, Diğer Giderler : {digerGiderler}");
//Console.WriteLine($"1.Aylık Gider Toplamı : {Giderler}");
//Console.WriteLine($"1.Aylık Gelir Gider Farkı {Gelirler - Giderler}");

////Operatörler
//// + * / - 
////Gelir ve Giderleri kalem kalem şeklinde 1 yıllık hesaplanacak.
////Toplam 1 yıllık gelir ve gider yazılıp farkı yazılacak.

////Yıllık Gelirler Kalem Kalem
//double YillikMaas = maas * 12;
//double YillikBurs = burs * 12;

////Yıllık Giderler Kalem Kalem
//double YillikKira = kira * 12;
//double YillikMutfak = mutfakMasrafi * 12;
//double YillikYolUcreti = yolMasrafi * 12;
//double YillikDigerGiderler = digerGiderler * 12;
////Yıllık Toplam Gelir Gider
//double YillikGelirler = Gelirler * 12;
//double YillikGiderler = Giderler * 12;

//Console.WriteLine();
//Console.WriteLine("Yıllık Olarak Gelirler Ve Giderler..");
//Console.WriteLine("Gelirler");
//Console.WriteLine($"Yıllık Maaş : {YillikMaas}, Yıllık Burs : {YillikBurs}");
//Console.WriteLine($"Yıllık Toplam Gelir : {YillikGelirler}");
//Console.WriteLine("Giderler");
//Console.WriteLine($"Yıllık Kira Bedeli : {YillikKira}, Yıllık Mutfak Ücreti : {YillikMutfak}, Yıllık Yol Ücreti : {YillikYolUcreti}, Yıllık Diğer Giderler : {YillikDigerGiderler}");
//Console.WriteLine($"Yıllık Toplam Gider : {YillikGiderler}");

//Console.WriteLine($"Yıllık Elde Kalan Gelir : {YillikGelirler - YillikGiderler}");

//I/O

//Console.WriteLine("Ad Girilecek Input");
//string isim = Console.ReadLine();
////Console.WriteLine("Soyad Girilecek Input");
//string soyisim = Console.ReadLine();

//int yas = int.Parse(Console.ReadLine());

