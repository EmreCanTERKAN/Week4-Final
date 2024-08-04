using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Final
{
    public class Bilgisayar : BaseMakine
    {
        private int usbGirisSayisi;
        public bool Bluetooth { get; set; }

        public int UsbGirisSayisi
        {
            get => usbGirisSayisi;
            set
            {
                if (value == 2 || value == 4)
                    usbGirisSayisi = value;
                else
                {
                    Console.WriteLine("Geçersiz USB Giriş Sayısı! -1 olarak atanıyor.");
                    usbGirisSayisi = -1;
                }
            }
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth: {(Bluetooth ? "Evet" : "Hayır")}");
        }

        public override string UrunAdiGetir()
        {
            return $"Bilgisayarınızın adı ---> {Ad}";
        }
    }
}
