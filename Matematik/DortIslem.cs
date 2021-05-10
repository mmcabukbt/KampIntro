using System;


namespace Matematik
{
    class DortIslem
    {
        public void Topla(double sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam Sonucu: " + toplam.ToString());
        }
        public void Carp(double sayi1, double sayi2)
        {
            double carpim = sayi1 * sayi2;
            Console.WriteLine("Toplam Sonucu: " + carpim.ToString());
        }
        public void Cikar(double sayi1, double sayi2)
        {
            double cikarim = sayi1 - sayi2;
            Console.WriteLine("Toplam Sonucu: " + cikarim.ToString());
        }
        public void Bol(double sayi1, double sayi2)
        {
            double bolum;
            if (sayi2 != 0)
            {
                bolum = sayi1 / sayi2;
            }
            else
            {
                bolum = sayi1 / 0.0000000000000000000001 ;
            }
            Console.WriteLine("Toplam Sonucu: " + bolum.ToString());
        }
    }
}
