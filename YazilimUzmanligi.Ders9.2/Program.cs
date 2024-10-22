
//Erişim Belirleyicileri
//Public => Heryerden erişilebilir olduğu anlamında.
//Private => Sadece tanımlandığı yerden kullanılabilir olduğu.
//Internal => Tanımlandığı proje içerisinde kullanılabilir.
//Protected => Miras Alınan sınıflar tarafından kullanılabilir.

//-------------------------------------------------------------------
//Metolar kendi içlerinde başka metotlar kullanabilirler. Kendilerinide kendi içlerinde kullanabilirler.
//Metotlar parametreli veya parametresiz olabilir.
//Metotlar geriye bişey dönebilir(int,string,List<int>) veya void(geriye dönüş yapmaz) yazılabilir.
//(erişim belirleyici) (metodun geri dönüş tipi) (metodun adı)() => Metot İmzası
//{//Metot Gövdesi

//}

//-------------------------------------------------------------
//ref - out//
//ref keyword kullanıldığında parametre olarak gönderilen değişkenin referansı üzerinde değişiklik yapar.--amacı gelen parametrenin kendi üzerinde bir değişiklik yapmak için kullanılır.
//out keyword kullandığında sadece dışarıya yeni değişkenler- referanslar oluşturur.--amacı metot içerisinden dışarıya birden fazla değer vermek için kullanılır.
using YazilimUzmanligi.Ders9._2;

int b = 2;
test(ref  b);//yukarıda oluşturulan b değişkenin referansı üzerinde yani kendisi üzerinde değişiklikyaptık.
void test(ref int b)
{
    b = 20;
}
//ref muhakkak parametre olarak gönderilmeden önce tanımlanmalıdır. Parametreyi alan metot gövdesinde kullanmak zorunda değildir.

//out keyword parametre olarak kullanıldığında bir metodun dışarıya birden fazla değer geri döndürmesini sağlar. out parametreler kullanılırken ref gibi daha önce tanımlanmış olmalarına ihtiyaç yoktur. Parametre geçilirken out (veritipi) (ismi) verildiğinde direk o isimde bir değişken oluşturacaktır. ref keywordden farklı olarak out parametre olarak kullanıldıysa metot gövdesinde muhakkak kullanılmalıdır.
int yas  =0;
outMetod(out yas,out string isim1,out bool aktif);//parametre olarak daha önce oluşmayan değişkenler burada oluşmaktadır.

void outMetod(out int yasparam, out string isim, out bool aktif)//Metot 3 tane değer dışarıya gönderiyor.
{//Gövdesinde out olarak geçilen parametrelerin değerlerini atıyor.
    yasparam = 27;
    isim = "Melih Ömer KAMAR";
    aktif = false;
}

//Metotlar normalde geriye sadece 1 değer return edebilir. Fakat bazı durumlarda birden fazla etmesini istyebiliriz. Budurumda Tuple nesnesi kullanılabilir.
//Tuple geri dönüş tipi birden fazla geri dönüş yapılması için kullanılır. Metotun imzasında geri dönüş tipi neler olacaksa sıralama olarak verilmeli ve bir parantez içerisinde alınmalıdır ().
(string, int, bool) tupleMetod()//Metot imzasında geri dönüş tipleri parantez içerisinde
{
    return ("Melih Ömer KAMAR", 27, true);// return edilirken değerler aynı sırayla parantez içerisinde olmalıdır.
}
//Erişme yol1
//var degerler = tupleMetod();
//degerler.Item1;
//degerler.Item2;
//degerler.Item3;
//-------------------------------
//Erişme yol2
//var (deger1,deger2,deger3) = tupleMetod();
//deger1;
//deger2;
//deger3;

//Parametrelerin Default(varsayılan) Değerleri olabilir. Bu parametreler boş geçilirse mevcuttaki değerini kullanacaktır. Ekstra parametreye değer gönderilirse mevcut değerini ezecektir.

Console.WriteLine($"Kdv Default (18) Olarak Hesaplanma : {Hesaplama(500)}");//kdv parametresi gönderilmedi default değeri kullanılıyor yani = 18
Console.WriteLine($"Kdv  (8) Olarak Hesaplanma : {Hesaplama(500,8)}");//kdv parametresine 8 değeri gönderildi 18'i ezip gönderilen değeri kullanacaktır. yani = 8
 int Hesaplama(int odenenUcret,int kdv = 18)//Metot kdv parametresi default 18 kullanıyor. Parametre olarak farklı bir değer gelirse onu kullanacak.
{
   return odenenUcret * kdv / 100;
}

//Bir Liste olacak içerisinde değerler olacak.
//bir metot yazılacak bu metot ona parametre olarak gelen listenin içerisinde kullanıcıdan aldığı değerleri ekleyecek.
//kullanıcıdan alınan değerlerin sayısı belli değil kullannıcı x tuşuna bastığınde yeni veri girişi yapamyacak.
//başka bir metot daha yazılacak buda parametre olarak aldığı listedeki kayıtları ekrana yazdıracak.
//ekleme metodu geriye işlem bittiğinde Ekleme işlemi sonlandırıldı diye bir mesaj dönecek.
//ekleme metodu dışarıya out keyword ile kaç kayıt eklendiğini bildirecek.
Console.Clear();



    List<string> Ogrenciler = new();

    string islemMesaji = OgrenciEkle(Ogrenciler, out int kayitSayisi);

    Console.WriteLine($"{islemMesaji} => ({kayitSayisi}) Adet Veri Eklenmiştir.");
    OgrenciListYazdir(Ogrenciler);

    string OgrenciEkle(List<string> parametreList, out int listCount)
    {
        while (true)
        {
            Console.WriteLine("Öğrenci Adı Giriniz.");
            string input = Console.ReadLine();

            if (input == "x")
            {
                listCount = parametreList.Count;
                return "Ekleme İşlemi Bitti. ";

            }
            parametreList.Add(input);
        }
    }
    void OgrenciListYazdir(List<string> paramList)
    {
        foreach (var item in paramList)
        {
            Console.WriteLine($"Öğrenciniz : {item}");
        }
    }


