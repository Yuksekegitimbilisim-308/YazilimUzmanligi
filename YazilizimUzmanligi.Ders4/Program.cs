

//Bir program yazılacak. Program consoldan yaş alacak. Alınan yaş 18 ve üstü ise reşitsiniz. Değilse reşit değilsiniz demeli.


#region Ödev1
//Console.WriteLine("Lütfen yaşınızı Giriniz.");

//int yas = int.Parse(Console.ReadLine());

//if (yas >= 18)
//{
//    Console.WriteLine($"Yaşınız : {yas} => Reşitsiniz.");
//}
//else if(yas < 18)
//{
//    Console.WriteLine("Yaşınız : "+yas+" => Reşit Değilsiniz.");
//   // Console.WriteLine("{0} {1} {2}", "Yaşınız :", yas, "=> Reşit Değilsiniz.");
//}
#endregion

#region Ödev2
//Kullanıcıdan kilo ve boy alınacak. Kullanıcının vücut kitle endeksi hesaplanacak.
//hesaplama =  kilo/(boy*boy)
//double boy = 0,kilo = 0,kitleIndex;

//Console.WriteLine("Lütfen Kilonuzu Giriniz.");
//kilo = double.Parse(Console.ReadLine());
//Console.WriteLine("Lütfen Boyunuzu Giriniz.");
//boy = double.Parse(Console.ReadLine());


//kitleIndex = kilo / (boy * boy);
//if (kitleIndex < 18.5)
//{
//    Console.WriteLine($"İdeal Kilonun Altındasınız. endeks değeri => {kitleIndex}");
//}
//else if(kitleIndex >= 18.5 && kitleIndex < 24.9)
//{
//    Console.WriteLine($"İdeal Kilonuzdasınız. endeks değeri => {kitleIndex}");

//}
//else if(kitleIndex >= 25 && kitleIndex < 29.9)
//{
//    Console.WriteLine($"İdeal Kilonuzun Üstündesiniz. endeks değeri => {kitleIndex}");

//}
//else if(kitleIndex >= 30 && kitleIndex < 39.9)

//{
//    Console.WriteLine($"İdeal kilonun çok üstünde (obez). endeks değeri => {kitleIndex}");

//}
//else if(kitleIndex >= 40)
//{
//    Console.WriteLine($"İdeal kilonun çok üstünde (morbid obez). endeks değeri => {kitleIndex}");

//}
#endregion

#region Ödev3


//Console.WriteLine("Lütfen Bir Gün Adı Giriniz.");
//string gun = Console.ReadLine();
//if (gun == "Pazartesi" || gun == "Salı" || gun == "Çarşamba" || gun == "Perşembe" || gun == "Cuma")
//{
//	Console.WriteLine($"Girilen Gün => {gun}. Hafta İçindesiniz.");
//}
//else if (gun == "Cumartesi" || gun == "Pazar")
//{
//	Console.WriteLine($"Girilen Gün => {gun}. Hafta Sonundasınız.");

//}
//else
//{
//	Console.WriteLine("Lütfen Geçerli bir gün giriniz.");
//}

//switch (gun.ToUpper()) ToUpper() metodu string değişkenlerin değerlerinin tüm karakterlerini büyük harfe çevirmeye yarar.
//{
//	case "PAZARTESİ":
//	case "SALI":
//	case "ÇARŞAMBA":
//	case "PERŞEMBE":
//	case "CUMA":
//		{
//            Console.WriteLine($"Girilen Gün => {gun}. Hafta İçindesiniz.");
//        }
//		break;
//	case "CUMARTESİ":
//	case "PAZAR":
//		Console.WriteLine($"Girilen Gün => {gun}. Hafta İçindesiniz.");
//		break;
//	default:
//		Console.WriteLine("Lütfen Geçerli bir gün giriniz.");
//		break;
//}
#endregion
//++  --
//Jump Deyimleri =>  break - Continue -goto - return

//int sayi = 15;
//int sayac = 3;
////int input = int.Parse(Console.ReadLine());
//basadon:
//Console.WriteLine("Tahmin Değerinizi Girin.");

//if (int.Parse(Console.ReadLine()) == sayi)
//{
//    Console.WriteLine("Tahmin Doğru.");
//    sayac--;
//}
//else
//{
//    Console.WriteLine("Tahmin Yanlış Tekrar Deneyiniz.");
//    sayac--;
//    if (sayac > 0)
//    {
//        goto basadon;
//    }
    
//}