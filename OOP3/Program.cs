using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
       IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        KonutKrediManager konutKrediManager = new KonutKrediManager();
        TasitKrediManager tasitKrediManager = new TasitKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService filelogerService = new FileLoggerService();

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);
        

       // ICreditManager konutKrediManaer = new KonutKrediManager();
       // yaparsak da aynı sonucu verirdi.

        List<ICreditManager>krediler = new List<ICreditManager>() {ihtiyacKrediManager,tasitKrediManager};
       // basvuruManager.KrediOnBilgilendirmeYap(krediler);
    }
} //SOLİD araştır