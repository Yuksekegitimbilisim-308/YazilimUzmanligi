namespace YazilimUzmanligi.Ders12
{
    public class BankaHesabi
    {
        //Encapsulation : OOP Kurallarındandır. Verileri kapsülleme anlamına gelir. Yani bir properites - field üzerinde get ve set işlemlerinde manipülasyon yapacaksak propertiesin get ve set bloklarını özelleştirir ve gerekli işlemleri yazarız.
        //Method :
        //Properties : 
        //Inheritence : 

        private string HesapNo { get; set; }
        private double _bakiye { get; set; }
        public double Bakiye
        {
            get
            {
                return _bakiye + 10;
            }
            set
            {
                if (value != 0)
                {
                    _bakiye = value;
                }
                else
                {
                    _bakiye = 50;
                }
            }
        }
        public string GetHesapNo()
        {
            if (HesapNo == null)
            {
                return "Hesap No Alanı Boş";
            }
            return HesapNo;
        }
        public void SetHesapNo(string paramHesapNo)
        {
            if (!string.IsNullOrEmpty(paramHesapNo)) //Alınan parametre null veya empty değilse ekleme işlemi yapılacak.
            {
                HesapNo = paramHesapNo;
            }
        }
        //private double Bakiye;
        //private string HesapNo;
        //public double GetBakiye()
        //{
        //    return Bakiye + 10;
        //}
        //public void SetBakiye(double paramBakiye)
        //{
        //    if (paramBakiye != 0)
        //    {
        //        Bakiye = paramBakiye;
        //    }
        //    else
        //    {
        //        Bakiye = 50;
        //    }
        //}
        //public string GetHesapNo()
        //{
        //    return HesapNo;
        //}
        //public void SetHesapNo(string paramHesapNo)
        //{
        //    HesapNo = paramHesapNo;
        //}
    }
}
