


Random rnd = new Random();//Rastgele Sayılar Üretebilen Sınıf Örneği Oluşturduk.
string karakterler = @"QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuıopğasdfghjklşizxcvbnmöç123456789\0!'^^+%&/()=?_{}[]";//Şifremizin İçerisinde Olmasını İstediğimiz Karakterleri Tanımladığımız Alan.
string password = "";//Karakterleri döngü içerisinde birleştirirken atama yapacağımız değişken.

for (int i = 0; i < 5; i++)//Bu Döngü içerisindeki kodların 5 kere çalışmasını sağlıyor. İçerisinde başka bir döngü ile şifre belirlemesi yapıyoruz yani toplamda 5 tane farklı şifre oluşturucak.
{
    for (int j = 0; j < 20; j++)//Bu döngü verdiğimiz uzunluk kadar dönecek ve içerisinde Random sınıfından aldığımız nesne örneği ile rastgele değerler oluşturucak bu değerler karakterlerin uzunluğu kadar olmalı.
    {
        int rndomIndex = rnd.Next(karakterler.Length);//rnd ile Next metoduna erişiyorum ve max alabileceği değeri karakterlerin uzunluğu kadar veriyorum en fazla o uzunlukta olabilecek bir sayısal değer üretiyor.
        password += karakterler[rndomIndex];//karakterlerin rastgele üretilen indexini yakalayıp değişkene += ile ekliyoruz. Her gelen yeni değer öncekinin yanına eklenerek birleşiyor.
    }
    Console.WriteLine(password);
    password = "";//Her şifre üretildikten sonra değişkenin içerisini boşaltıyoruz.
}
Console.Clear();
string karakterler1 = @"QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuıopğasdfghjklşizxcvbnmöç123456789\0!'^^+%&/()=?_{}[]";
Random rnd1 = new Random();
string sifre = "";
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 12; j++)
    {
        int rastgeleDeger = rnd1.Next(karakterler1.Length);
        sifre += karakterler1[rastgeleDeger];
    }
    Console.WriteLine(sifre);
    sifre = "";
}

//1- Liste oluşturulacak. İçerisine kişi isimleri eklenecek. İsimler konsoldan kullanıcıdan alınacak.
//2- Aldığımız değerler bittiğinde Random sınıfından bir nesne oluşturulacak.
//3- Bu random nesnesi ile bir döngü içerisinde, oluşturulan listenin elemanlarından 3 tane seçmesi gerekmekte.
Console.Clear();

//KuraCalistir();


void KuraCalistir()
{
    List<string> kuraListesi = IsimAl();
    int kuraTekrar = KuraSayisi();
    KuraCekim(kuraTekrar, kuraListesi);
}

List<string> IsimAl()
{
    List<string> isimler = new();

    while (true)
    {
        Console.WriteLine("Lütfen Kura İçin İsim Giriniz.");
        string isim = Console.ReadLine();
        if (isim == "x")
        {
            break;
        }
        isimler.Add(isim);
    }

    return isimler;
}
int KuraSayisi()
{
    Console.WriteLine("Kaç Kişi Seçilmeli ? ");
    int kuraSayisi = int.Parse(Console.ReadLine());//Yukarıda alınan değerlerden kaç tane seçilmesini soruyoruz.
    if (kuraSayisi <3)
    {
        kuraSayisi = 3;
    }
    return kuraSayisi;
}
void KuraCekim(int kuraCekimSayisi,List<string> isimler)
{
    Console.Clear();
    Random rastgele = new Random();//Random sınıfından bir örnek oluşturdum adına rastgele dedim.
    for (int i = 0; i < kuraCekimSayisi; i++)//Yukarıda konsoldan aldığım kaç kişi değerini bu döngüye veriyorum ve kaç kişi seçilmesini istediysem o değer geliyor.Döngüde budurumda o kadar dönüyor.
    {
        //Döngü her döndüğünde
        int index = rastgele.Next(isimler.Count);//rastgele.Next() metodu bir sayısal değer üretiyor bu değer max isimler listesinin uzunluğu kadar olabilir diye belirtiyorum.
        string isim = isimler[index];//bulduğumuz index numarası listenin kaçıncı elemanına denk geliyorsa o elemanı isim değişkenine atıyoruz.
        Console.WriteLine($"{i+1}.{isim}");//atadığımız değişkeni ekrana bastırıyoruz.
        isimler.RemoveAt(index);//Kuradan çıkan kişiyi isimler listesinden çıkarıyoruz tekrar aynı kişi denk gelmemesi için.
                                //isimler.Remove(isim);
    }
}



//3 liste olucak
//1. liste model ve marka 2. liste model yılı 3.liste araç kazalımı değilmi bilgilerini tutucak.
//bir metot içerisinde bu 3 listeninde değerleri kullanıcıdan alınarak doldurulacak.
//başka bir metot ile bu listeler dönülerek ekrana çıktı verilecek.

var (markamodel, modelyil, arackazalimi) = BilgiAl();
BilgiVer(markamodel,modelyil, arackazalimi);
Console.Clear();
Console.WriteLine("Lütfen Filtrelenecek Araç Markasını Giriniz.");
string inputMarka = Console.ReadLine();

for (int i = 0; i < markamodel.Count; i++)
{
    if (inputMarka == markamodel[i])
    {
        Console.WriteLine($"Marka Model : {markamodel[i]} Model Yılı : {modelyil[i]}");
    }
}


//Console.WriteLine("Lütfen Filtre İçin Model Yılını Giriniz.");
//int inputModelYil  = int.Parse(Console.ReadLine());
//Console.WriteLine("Verilen Yıldan Büyükler için 1 Küçük kayıtlar 2 seçiniz.");
//int inputSecenek = int.Parse(Console.ReadLine());

//for (int i = 0; i < modelyil.Count; i++)
//{
//    if (inputSecenek ==1 && modelyil[i] > inputModelYil)
//    {
//        Console.WriteLine($"Araç Model Marka : {markamodel[i]} Model Yılı : {modelyil[i]}");
//    }
//    else if (inputSecenek == 2 && modelyil[i]< inputModelYil)
//    {
//        Console.WriteLine($"Araç Model Marka : {markamodel[i]} Model Yılı : {modelyil[i]}");

//    }
//}

//foreach (var item in modelyil)
//{
//    if (item < inputModel && inputSecenek == 1)
//    {
//        Console.WriteLine("Model Yılı Araç");
//    }

//}


(List<string>,List<int>,List<bool>) BilgiAl()
{
    List<string> aracMarkaModel = new();
    List<int> aracModelYil = new();
    List<bool> aracKazalimi = new();
    while (true)
    {
        Console.WriteLine("Araç Marka Model Giriniz. Çıkış İçin x giriniz.");
        string aracModelMarka = Console.ReadLine();
        if (aracModelMarka == "x")
        {
            break;
        }
        Console.WriteLine("Araç Model Yılını Giriniz.");
        int modelYil = int.Parse(Console.ReadLine());
        Console.WriteLine("Araç Kazalımı Kazalıysa 1 değilse 2 giriniz.");
        int kazalimi = int.Parse(Console.ReadLine());
        aracMarkaModel.Add(aracModelMarka);
        aracModelYil.Add(modelYil);
        if (kazalimi == 1)
        {
            aracKazalimi.Add(true);
        }
        else
        {
            aracKazalimi.Add(false);
        }
    }
    return (aracMarkaModel, aracModelYil, aracKazalimi);
}
void BilgiVer(List<string> markaModelList,List<int> modelYilList,List<bool> aracKazaList)
{
    
    for (int i = 0; i < markaModelList.Count; i++)
    {
        string kazaDurumu = "Araç Kazasız.";
        if (aracKazaList[i] == true)
        {
            kazaDurumu = "Araç Kazalı.";
        }
        Console.WriteLine($"Marka Model : {markaModelList[i]} Model Yılı : {modelYilList[i]} Araç Kazalımı : {kazaDurumu}");
    }

}