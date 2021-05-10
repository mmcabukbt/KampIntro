using System;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediTuruManager
    {
        public void BasvuruYap()
        {
            Console.WriteLine("İhtiyaç Kredisi Başvurusu yapıldı!");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı!");
        }
    }
}
