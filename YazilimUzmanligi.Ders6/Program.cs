//10 adet sayı alınacak diziye eklenecek.
//sayıların ortalaması  ve toplamı alınacak.
//double[] sayilar = new double[3];
//double toplamSayi = 0;
//Console.WriteLine("Lütfen 10 adet sayı giriniz.");
//for (int i = 0; i < sayilar.Length; i++)
//{
//    Console.WriteLine($"Lütfen {i+1}. Sayıyı Giriniz.");
//    sayilar[i] = double.Parse(Console.ReadLine());
//    toplamSayi += sayilar[i];
//}
//double ortalama = toplamSayi / sayilar.Length;
//Console.Clear();
//Console.WriteLine($"Dizideki Toplam Değer : {toplamSayi}");
//Console.WriteLine($"Dizideki Değerlerin Ortalaması :{ortalama}");
//-------------------------------------------------------------------
//5 sayı alınıp diziye ata.
//sort ve reverse ile en büyük en küçük bul.

//int[] sayilar = { 64, 97, 15, 32,33 };
//for (int i = 0; i < sayilar.Length; i++)
//{
//    Console.WriteLine($"{sayilar[i]}");
//}
//Array.Sort(sayilar);//A-z 0-1
//int enKucuk = sayilar[0];
//Array.Reverse(sayilar);
//int enbuyuk = sayilar[0];
//Console.WriteLine($"Dizinin En küçük Elemanı : {enKucuk}");
//Console.WriteLine($"Dizinin En Büyük Elemanı : {enbuyuk}");

//Kullanıcıdan 10 adet sayı alınacak.
//sayıları çift ve tek olarak ayrı dizilere eklenecek.
//çıktı  : kaçtane tek ve çift sayı oldugu ve sayıları yazdır.
//int[] sayilar = new int[10];
//int toplamTekSayi = 0;
//int toplamCiftSayi = 0;

//for (int i = 0; i < sayilar.Length; i++)
//{
//    Console.WriteLine($"Lütfen {i}.Değeri Girinz.");
//    int input = int.Parse(Console.ReadLine());
//    if (input % 2 == 0)
//    {
//        toplamCiftSayi++;
//    }
//    else if(input % 2 != 0) 
//    {
//        toplamTekSayi++;
//    }
//    sayilar[i] = input;
//}
//int[] tekSayilar = new int[toplamTekSayi];
//int[] ciftSayilar = new int[toplamCiftSayi];
//int ciftIndex = 0;
//int tekIndex= 0;

//for (int i = 0; i < sayilar.Length; i++)
//{
//    if (sayilar[i] %  2 == 0)
//    {
//        ciftSayilar[ciftIndex] = sayilar[i];
//        ciftIndex++;
//    }else
//    {
//        tekSayilar[tekIndex] = sayilar[i];
//        tekIndex++;
//    }

//}
//Console.WriteLine($"Tek Sayıların Toplam Adedi : {tekSayilar.Length}");
//for (int i = 0; i < tekSayilar.Length; i++)
//{
//    Console.WriteLine($"{tekSayilar[i]}");
//}
//Console.WriteLine($"Çift Sayıların Toplam Adedi : {ciftSayilar.Length}");
//for (int i = 0; i < ciftSayilar.Length; i++)
//{
//    Console.WriteLine($"{ciftSayilar[i]}");
//}

//int[] sayilar2 = { 15, 28, 59, 64, 32, 35, 88, 57, 11, 18 };
//int ciftSayiAdedi = 0;
//int tekSayiAdedi = 0;
//for (int i = 0;i < sayilar2.Length;i++)
//{
//    if (sayilar2[i] % 2 == 0)
//    {
//        ciftSayiAdedi++;
//    }
//    else
//    {
//        tekSayiAdedi++;
//    }

//}
//int[] ciftSayilar = new int[ciftSayiAdedi];
//int[] tekSayilar = new int[tekSayiAdedi];
//int ciftSayiIndex = 0;
//int tekSayiIndex = 0;

//for (int i = 0; i < sayilar2.Length; i++)
//{
//    if (sayilar2[i] % 2 == 0)
//    {
//        ciftSayilar[ciftSayiIndex] = sayilar2[i];
//        ciftSayiIndex++;
//    }
//    else
//    {
//        tekSayilar[tekSayiIndex] = sayilar2[i];
//        tekSayiIndex++;
//    }
//}

//Koleksiyonlar Diziler - Listeler
//List<int> listem = new List<int>() { 1,2,6,8};
//List<int> listem2 = new() { };
//List<string> sinifListesi = new();
//sinifListesi.Add("Melih Ömer");
//sinifListesi.Add("Mert");
//sinifListesi.Add("Batuhan");
//sinifListesi.Add("Doğuş");
//sinifListesi.Add("Ömer Faruk");
//sinifListesi.Add("Abdullah");

//for (int i = 0; i < sinifListesi.Count; i++)
//{
//    Console.WriteLine($"{sinifListesi[i]}");
//}
//sinifListesi.OrderBy(x => x);
//sinifListesi = sinifListesi.OrderBy(x => x).ToList();
//Console.WriteLine("-----------------");
//for (int i = 0; i < sinifListesi.Count; i++)
//{
//    Console.WriteLine($"{sinifListesi[i]}");

//}
//sinifListesi = sinifListesi.OrderByDescending(x => x).ToList();
//Console.WriteLine("-----------------");

//for (int i = 0; i < sinifListesi.Count; i++)
//{
//    Console.WriteLine($"{sinifListesi[i]}");

//}

//List<int> notlar = new();
//notlar.Add(50);
//notlar.Add(80);
//notlar.Add(15);
//notlar.Add(20);
//notlar.Add(40);
//notlar.Add(57);
//notlar.Add(69);


//int toplamNot = 0;
//int ortalama = 0;

//for (int i = 0; i < notlar.Count; i++)
//{
//    toplamNot += notlar[i];
//}
//Console.WriteLine($"Toplam Not : {toplamNot}");
//ortalama = toplamNot / notlar.Count;
//Console.WriteLine($"Ortalama : {ortalama}");

//List<string> yemekler = new();
//List<double> fiyatlar= new();
//bool donguTekrar = true;
//Console.WriteLine("Lütfen yemeklerin Adını Sonrasında Fiyatını Giriniz. Çıkmak için 'x' giriniz.");
//for (int i = 0; donguTekrar; i++)
//{
//    Console.WriteLine("Lütfen Yemek Adı Giriniz.");
//    string yemekAdi = Console.ReadLine();
//    if (yemekAdi.ToUpper() == "X")
//    {
//        break;
//    }
//    yemekler.Add(yemekAdi);
//    Console.WriteLine("Lütfen Fiyatı Giriniz.");
//    double yemekFiyati = double.Parse(Console.ReadLine());
//    fiyatlar.Add(yemekFiyati);
//}
//
//double toplamTutar = 0;
//while (true)
//{
//    Console.WriteLine("Lütfen Yemek adı gir");
//    string yemekAdi = Console.ReadLine();
//    if (yemekAdi.ToUpper() == "X")
//    {
//        break;
//    }
//    yemekler.Add(yemekAdi);
//    Console.WriteLine("Lütfen Fiyatı Giriniz.");
//    double yemekFiyati = double.Parse(Console.ReadLine());
//    fiyatlar.Add(yemekFiyati);
//    Console.WriteLine($"");
//}
//for (int i = 0; i < yemekler.Count; i++)
//{
//    Console.WriteLine($"{yemekler[i]} => Fiyatı {fiyatlar[i]}");
//    toplamTutar += fiyatlar[i];
//}
//Console.WriteLine($"Yenilen Yemek Çeşitleri: {yemekler.Count}");
//Console.WriteLine($"Toplam Ödenecek Tutar : {toplamTutar}");
//do
//{
//    Console.WriteLine("Lütfen Yemek adı gir");
//    string yemekAdi = Console.ReadLine();
//    if (yemekAdi.ToUpper() == "X")
//    {
//        break;
//    }
//    yemekler.Add(yemekAdi);
//    Console.WriteLine("Lütfen Fiyatı Giriniz.");
//    double yemekFiyati = double.Parse(Console.ReadLine());
//    fiyatlar.Add(yemekFiyati);
//} while (false);


//Kullanıcıdan 10- n adet sayı alınacak.
//sayıları çift ve tek olarak ayrı dizilere eklenecek.
//çıktı  : kaçtane tek ve çift sayı oldugu ve sayıları yazdır.
//List<int> sayilar = new();
//List<int> Teksayilar = new();
//List<int> Ciftsayilar = new();

//Console.WriteLine("Lütfen Kaç Adet Sayı Gireceğinizi Belirtin.");
//int toplamSayi = int.Parse(Console.ReadLine());
//int index = 0;

//while (index < toplamSayi)
//{
//    Console.WriteLine("Lütfen Sayınızı Giriniz.");
//    int sayi = int.Parse(Console.ReadLine());
//    sayilar.Add(sayi);
//    if (sayi % 2 == 0)
//    {
//        Ciftsayilar.Add(sayi);
//    }
//    else
//    {
//        Teksayilar.Add(sayi);
//    }
//    index++;

//}
//for (int i = 0; i < toplamSayi; i++)
//{
//    Console.WriteLine("Lütfen Sayınızı Giriniz.");
//    int sayi = int.Parse(Console.ReadLine());
//    sayilar.Add(sayi);
//    if (sayi % 2 == 0)
//    {
//        Ciftsayilar.Add(sayi);
//    }
//    else
//    {
//        Teksayilar.Add(sayi);
//    }
//}
//Console.WriteLine($"Toplam Tek Sayı : {Teksayilar.Count}");
//Console.WriteLine("Tek sayıları Listesi");
//for (int i = 0; i < Teksayilar.Count; i++)
//{
//    Console.WriteLine($"{Teksayilar[i]}");
//}
//Console.WriteLine($"Toplam Çift Sayı : {Ciftsayilar.Count}");
//for (int i = 0; i < Ciftsayilar.Count; i++)
//{
//    Console.WriteLine($"{Ciftsayilar[i]}");
//}

//List<string> isimler = new() { "Melih", "Mert", "Doğuş", "Batuhan", "Ömer Faruk", "Abdullah" };
//Console.WriteLine("Liste Toplam Elaman Sayısı : " + isimler.Count);
//isimler.Remove("Mert");
//Console.WriteLine("Liste Toplam Elaman Sayısı : "+isimler.Count);
//for (int i = 0; i < isimler.Count; i++)
//{
//    Console.WriteLine($"{isimler[i]}");
//}
//foreach (var item in isimler)
//{
//    Console.WriteLine(item);
//}