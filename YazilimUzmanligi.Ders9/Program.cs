

//Erişim Belirleyicileri
//Public => Heryerden erişilebilir olduğu anlamında.
//Private => Sadece tanımlandığı yerden kullanılabilir olduğu.
//Internal => Tanımlandığı proje içerisinde kullanılabilir.
//Protected => Miras Alınan sınıflar tarafından kullanılabilir.

//Methodlar
//ref  -   out


Testmethod("Melih Ömer KAMAR",27, meslek: "Yazılım Geliştirici");

Testmethod("Mert",25, meslek: "Yazılım Eğitmeni");

int toplamSayilar = Toplama(60, 50);
Console.WriteLine($"Toplama metodu Geri Dönüşü : {toplamSayilar}");
void Testmethod(string isim,int yas,string meslek)//Metodun imzası
{//Metodun Gövdesi
    Console.WriteLine($"Adı Soyadı : {isim} Yaşı : {yas} Meslek : {meslek}");
}
Console.Clear();
int a = 5;//#45465asd = 60
Console.WriteLine("a : "+ a);
 test(ref a);
Console.WriteLine("a : "+ a);
Console.Clear();

var degerler =  tupleMetod();


var (isim,yas,aktif) = tupleMetod();
Console.WriteLine(isim);
Console.WriteLine(yas);
Console.WriteLine(aktif);

int yas2 = 0;
string isim1;

Console.WriteLine("-*-*-*-*-*-*-*-*-*-*");

outMetod(out yas2, out  isim1, out bool aktif3);
Console.WriteLine(yas2);
Console.WriteLine(isim1);
Console.WriteLine(aktif3);
Console.Clear();
List<string> ogrenciIsimleri = new() { "Melih Ömer", "Ömer Faruk", "Mer", "Doğuş", "Batuhan", "Abdullah", "Habibe" };
OgrenciListeYazdir(ogrenciIsimleri);



void outMetod(out int yas,out string isim,out bool aktif)
{
    yas = 27;
    isim = "Melih Ömer KAMAR";
    aktif = false;
}

(string,int,bool) tupleMetod()
{
    return ("Melih Ömer KAMAR",27,true);
}
void test(ref int b)//45465asd12asd
{
    b = 60;
}
int Toplama(int sayi1,int sayi2)
{
    return sayi1 + sayi2;
}

int dynamicToplama(int sayi1)
{
    Console.WriteLine("2. Sayıyı Gir");
    int input =  int.Parse(Console.ReadLine());
    return input + sayi1;
}

//diziler - listeler - classlar

void OgrenciListeYazdir(List<string> isimler)
{
    foreach (var isim in isimler)
    {
        Console.WriteLine($"Öğrenci Adı :{isim}");
    }
}

