using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun0 = new Urun();
            urun0.Id = 0;
            urun0.Adi = "Elma";
            urun0.Fiyati = 15.0;
            urun0.Aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Çilek";
            urun1.Fiyati = 18.0;
            urun1.Aciklama = "Çilek gibi çilek";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 8.0;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun0, urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("---------------Metotlar-------------");

            SepetManager sepetManager = new SepetManager();

            Console.WriteLine("---------------Class kullanarak-------------");
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun0);
            sepetManager.Ekle(urun2);

            Console.WriteLine("---------------3 parametre kullanarak------------");
            sepetManager.Ekle2("Armut", 5.0, "Tatlı Armut", 20);
            sepetManager.Ekle2("Muz", 25.0, "İthal Muz", 35);
            sepetManager.Ekle2("Portakal", 9.0, "Waşington Portakal", 15);

            //Console.WriteLine(urunler.Length);

        }
    }
}
