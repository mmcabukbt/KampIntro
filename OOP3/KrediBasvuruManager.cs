using System;
using System.Collections.Generic;

namespace OOP3
{
    class KrediBasvuruManager
    {
        public void BasvuruYap(IKrediTuruManager krediTuru, List<ILoggerService> loggerServices)
        {
            krediTuru.BasvuruYap();
            krediTuru.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediTuruManager> krediTuruList)
        {
            foreach (var krediTuru in krediTuruList)
            {
                krediTuru.Hesapla();
            }
        }
        public void KrediOnBilgilendirmesiYapVeLogla(List<IKrediTuruManager> krediTuruList, List<ILoggerService> loggerServices)
        {
            foreach (var krediTuru in krediTuruList)
            {
                krediTuru.Hesapla();
                foreach (var loggerService in loggerServices)
                {
                    loggerService.Log();
                }
            }
        }
    }
}
