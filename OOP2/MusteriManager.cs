using System;

namespace OOP2
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri yenimusteri)
        {
            Console.WriteLine(yenimusteri.GetType() + "=> Tipinde yeni Müşteri Eklendi!");
        }
    }
}
