using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Final
{
    public class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı: {(TrLisansli ? "Evet" : "Hayır")}");
        }

        public override string UrunAdiGetir()
        {
            return $"Telefonunuzun adı ---> {Ad}";
        }
    }
}

