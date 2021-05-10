using System;

namespace OOP3
{
    class EsnafKrediManager : IKrediTuruManager
    {
        public void BasvuruYap()
        {
            Console.WriteLine("Esnaf Kredisi Başvurusu yapıldı!");
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Ödeme Planı Hesaplandı!");
        }
    }
}
