using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediTuruManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediTuruManager tasitKrediManager = new TasitKrediManager();
            IKrediTuruManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DBLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SMSLoggerService(), new FileLoggerService() };
            KrediBasvuruManager basvuruManager = new KrediBasvuruManager();
            
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);
            Console.WriteLine("----------------------------------------------------------");
            
            List<IKrediTuruManager> krediler = new List<IKrediTuruManager>() { ihtiyacKrediManager, tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.WriteLine("----------------------------------------------------------");

            List<IKrediTuruManager> tumkrediler = new List<IKrediTuruManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager, new EsnafKrediManager()};
            List<ILoggerService> tumloggers = new List<ILoggerService> { databaseLoggerService, fileLoggerService, new SMSLoggerService()};
            basvuruManager.KrediOnBilgilendirmesiYapVeLogla(tumkrediler, tumloggers);

        }
    }
}
