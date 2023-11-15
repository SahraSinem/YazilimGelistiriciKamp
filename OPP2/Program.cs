using OPP2;

internal class Program
{
    private static void Main(string[] args)
    {
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Id = 1;
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Engin";
        musteri1.Soyadi = "Demirog";
        musteri1.TcNo = "12345";

        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "54321";
        musteri2.VergiNo = "99999";
        musteri2.SirketAdi = "kodlama.oi";



        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();
    }
}