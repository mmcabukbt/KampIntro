using System;

namespace OOP3
{
    class KonutKrediManager : IKrediTuruManager
    {
        public void BasvuruYap()
        {
            Console.WriteLine("Konut Kredisi Başvurusu yapıldı!");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı!");
        }
    }
}
