using Week4_Final;

class Program
{
   static public void Main()
    {
        bool devamEt = true;

        while (devamEt)
        {
            Console.WriteLine("Telefon üretmek için 1'e, Bilgisayar üretmek için 2'ye basınız:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();
                Console.Write("Seri Numarası: ");
                telefon.SeriNumarasi = Console.ReadLine();
                Console.Write("Ad: ");
                telefon.Ad = Console.ReadLine();
                Console.Write("Açıklama: ");
                telefon.Aciklama = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                telefon.IsletimSistemi = Console.ReadLine();
                Console.Write("TR Lisanslı mı? (E/H): ");
                telefon.TrLisansli = Console.ReadLine().ToUpper() == "E";

                Console.WriteLine("Telefon başarıyla üretildi!");
                telefon.BilgileriYazdir();
                Console.WriteLine(telefon.UrunAdiGetir());
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();
                Console.Write("Seri Numarası: ");
                bilgisayar.SeriNumarasi = Console.ReadLine();
                Console.Write("Ad: ");
                bilgisayar.Ad = Console.ReadLine();
                Console.Write("Açıklama: ");
                bilgisayar.Aciklama = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();
                Console.Write("USB Giriş Sayısı: ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());
                Console.Write("Bluetooth var mı? (E/H): ");
                bilgisayar.Bluetooth = Console.ReadLine().ToUpper() == "E";

                Console.WriteLine("Bilgisayar başarıyla üretildi!");
                bilgisayar.BilgileriYazdir();
                Console.WriteLine(bilgisayar.UrunAdiGetir());
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyiniz.");
                continue;
            }

            Console.Write("Başka bir ürün üretmek ister misiniz? (E/H): ");
            devamEt = Console.ReadLine().ToUpper() == "E";
        }

        Console.WriteLine("İyi günler!");


    }
}