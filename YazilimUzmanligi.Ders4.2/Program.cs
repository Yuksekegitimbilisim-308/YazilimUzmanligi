//Döngüler
//For - do While - Foreach

//for (int index = 1; index <= 5; index++)
//{
//    Console.WriteLine($"{index}.Sıra Dönüyor");
//}

//i%2 ==0
//for (int i = 0; i < 100; i++)
//{

//    if (i %2 == 0)
//    {
//        Console.WriteLine($"{i+2} Çift Sayıdır.");
//    }
//    else
//    {
//        Console.WriteLine($"{i+2} Tek Sayıdır.");
//    }

//}

//tahmin edilecek bir sayı belirleyin.
//5 kere dönecek bir döngü oluşturun.
//kullanıcı tahmin giricek.
//girilen tahmin sizin belirlediğinizden büyükse daha küçük giriniz.
//girilen tahmin sizin belirlediğinizden küçükse daha büyük giriniz desin.
int tahminSayisi = 25;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Lütfen Tahminizi Giriniz.");
    int tahmin = int.Parse(Console.ReadLine());
    if (tahmin == tahminSayisi)
    {
        Console.WriteLine("Tebrikler Tahmin Doğru.");
        break;
    }
    else if(tahmin > tahminSayisi)
    {
        Console.WriteLine("Daha Küçük Bir Sayı Giriniz.");
    }
    else if (tahmin < tahminSayisi)
    {
        Console.WriteLine("Daha Büyük Bir Sayı Giriniz.");
    }
}