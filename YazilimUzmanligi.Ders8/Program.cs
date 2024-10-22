

class Program
{
    static void Main(string[] args)
    {
        //Metotlar kod tekrarını önlemek amaçlı tekrar tekrar kullanabildiğimiz yapılardır.
        /*
         * Metotların imzaları ve gövdeleri vardır imzaları => (erişim belirleyici) (dönüşTipi) (metotAdı) ()
         * Gövdelerinde metotların yapmasını istediğimiz işleri bulundururlar.
         * Parametreli - Parametresiz / Dönüş Tipi Olan - Dönüş Tipi Olmayan olarak ayrılırlar.
         * --Geri Dönüş tipi olmayan metotlara void yazarız. Geri Dönüş tipi olan metotların tipi ne ise onu yazarız örneğin metinsel bir ifade geriye dönecekse string.
         * Geriye değer döndüren metot içerisinde döneceği değeri return ile belirtiriz. Değer dönüyorsa muhakkak return yazmalıyız.
         * Parametrelerin sınırı yoktur istediğimiz kadar parametre verebiliriz. Parametreler birbirlerinden ',' ile ayrılırlar
         * Örnek geriye dönüş yapmayan metot tanımlaması 
         * --Parametresiz geriye dönüş yapmayan metot
         * void TestMethod(){}
         * --Parametreli geriye dönüş yapmayan metot
         * void TestMethod(string parametre){}  => string tipinde 1 adet parametre alacaktır.
         * Örnek Geriye Dönüş yapan metot
         * --Parametresiz geriye dönüş yapan metot
         * int TestMethod(){} => return ile muhakkak int tipinde bir değer döndürmelidir.
         * --Parametreli geriye dönüş yapan metot
         * int TestMethod(string parametre){} >= string tipinde 1 adet parametre alır ve geriye int tipinde değer döner.
         * */
        Console.WriteLine("Lütfen Kontrol Edeceğiniz Sayıyı Giriniz.");
        int inputSayi = int.Parse(Console.ReadLine());

        TekCiftKontrol(inputSayi);


        int TekCiftKontrol(int parametreSayi)
        {
            if (parametreSayi % 2 == 0)
            {
                Console.WriteLine($"{parametreSayi} => Girilen Sayı Çifttir.");
                return parametreSayi;
            }
            else
            {
                Console.WriteLine($"{parametreSayi} => Girilen Sayı Tektir.");
                return parametreSayi;
            }
        }



        //string kullaniciAdi = "admin";
        //string sifre = "admin123";
        ////Kullanıcıdan 2 değer alınacak kullanıcı adı ve şifre 
        ////alınan değerler Login adında metoda parametre olarak gönderilecek.
        ////metod geri dönüşü olarak kullanıcının giriş bilgileri doğru ise true yanlış ise false dönecek.
        ////metot geri dönüş değeri true ise ekrana giriş başarılı yazak false ise başarısız yazak.

        //Console.WriteLine("Kullanıcı Adı Şifre Giriniz.");
        //string inputKullaniciAdi = Console.ReadLine();
        //Console.WriteLine("Şifrenizi Giriniz.");
        //string inputSifre = Console.ReadLine();
        //bool girisDurumu = Login(inputKullaniciAdi, inputSifre);
        //GirisDurumuYazdir(girisDurumu);
        //void GirisDurumuYazdir(bool giris)
        //{
        //    if (giris)
        //    {
        //        Console.WriteLine("Giriş Başarılı.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Giriş Başarısız.");
        //    }
        //}
        //bool Login(string paramKullaniciAdi, string paramSifre)
        //{
        //    if (paramKullaniciAdi == kullaniciAdi && paramSifre == sifre)
        //    {
        //        return true;
        //    }
        //    return false;

        //}
        //(metot geri dönüş tipi) (metot adı) (alacağı parametreler) => Metot tanımlama şablonu

        ////Console.WriteLine($"1. Metodun Geri Dönüşü : {Toplama(2, 6)}");
        ////int toplam = Toplama(15, 60);
        ////Console.WriteLine($"2. Metodun Geri Dönüşü : {toplam}");
        ////int toplam2 = Toplama(500, 670);
        ////Console.WriteLine($"3. Metodun Geri Dönüşü : {toplam2}");
        ////string metin = "Ben 2. Metoddan yazdırıldım.";
        ////LogYaz();
        ////KonsolaYaz("Ben 1. Metoddan yazdırıldım.");
        ////LogYaz();
        ////KonsolaYaz(metin);
        ////Tuple nesnesi geriye dönüşü yakalama yol1
        ////var geriyeDonenler =   Carpma(5,5);
        //////Tuple Nesnesi geriye dönüşü yakalama yol2
        ////var (metinsel, sayisal, dogruyanlis) = Carpma(5,5)
        //Console.WriteLine("1. Sayıyı Giriniz.");
        //int sayi1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Yapacağınız İşlemin Operatörünü Giriniz.(+ / * -)");
        //char operatorr = char.Parse(Console.ReadLine());
        //Console.WriteLine("2. Sayıyı Giriniz.");
        //int sayi2 = int.Parse(Console.ReadLine());

        //switch (operatorr)
        //{
        //    case '+':
        //        Console.Clear();
        //        Console.WriteLine(Toplama(sayi1, sayi2));
        //        break;
        //    case '-':
        //        Console.Clear();
        //        Console.WriteLine(Cikarma(sayi1, sayi2));
        //        break;
        //    case '/':
        //        Console.Clear();
        //        Console.WriteLine(Bolme(sayi1, sayi2));
        //        break;
        //    case '*':
        //        Console.Clear();
        //        Console.WriteLine(Carpma(sayi1, sayi2));
        //        break;
        //    default:
        //        Console.Clear();
        //        Console.WriteLine("Lütfen Geçerli Bir Operatör Giriniz.");
        //        break;
        //}
    }


    #region HesapMakinası Metodları
    static int Toplama(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    static int Carpma(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
    static int Bolme(int sayi1, int sayi2)
    {
        return sayi1 / sayi2;
    }
    static int Cikarma(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
    #endregion

    static void KonsolaYaz(string yazdirilicakMetin)
    {
        Console.WriteLine($"{yazdirilicakMetin}");
    }


    static void LogYaz()
    {
        Console.WriteLine($"Log Zamanı : {DateTime.Now}");
    }
    //Method Override Başlangıç
    //static int Toplama(int sayi1, int sayi2)//Methodun İmzası
    //{
    //    int toplam = sayi1 + sayi2;//Methodun Gövdesi
    //    string mesaj = "Toplama İşlemi Başarılı";
    //    Console.WriteLine(mesaj);
    //    return toplam;
    //}
    static double Toplama(int sayi1, double sayi2)//Methodun İmzası
    {
        double toplam = sayi1 + sayi2;//Methodun Gövdesi
        string mesaj = "Toplama İşlemi Başarılı";
        Console.WriteLine(mesaj);
        return toplam;
    }
    //Method Override Bitiş
    //Tuple Nesnesi ile geriye dönüş değerleri.
    //static (string,int,bool) Carpma(int sayi1,int sayi2)
    //{
    //    int carpim  = sayi1 * sayi2;
    //    return ("İşlem Başarılı",carpim,true);
    //}

}


