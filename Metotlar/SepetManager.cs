using System;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! " + urun.Adi + " Sepete Eklendi!");
        }

        public void Ekle2(string urunAdi, double urunFiyati, string urunAciklama, int stokAdet )
        {
            Console.WriteLine("Tebrikler! " + urunAdi + " Sepete Eklendi!");
        }
    }
}
