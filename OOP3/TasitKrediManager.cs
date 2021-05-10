using System;

namespace OOP3
{
    class TasitKrediManager : IKrediTuruManager
    {
        public void BasvuruYap()
        {
            Console.WriteLine("Taşıt Kredisi Başvurusu yapıldı!");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı!");
        }
    }
}
