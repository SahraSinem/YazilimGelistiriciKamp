using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class BasvuruManager
        // method injection 
    {
        public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService) 
        {
            // Başvuran bilgileri değerlendirme

            creditManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmeYap(List<ICreditManager>krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
