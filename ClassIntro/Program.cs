using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 85;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "ASP.Net";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 83;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Halil İbrahim";
            kurs4.IzlenmeOrani = 100;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + ": " + kurs.KursAdi + " => %" + kurs.IzlenmeOrani);
            }








        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }


}
