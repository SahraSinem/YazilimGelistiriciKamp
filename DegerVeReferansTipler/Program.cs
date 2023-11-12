internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        // sayi1 ?? 30

        int[] sayilar1= new int[] {10,20,30};
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2; // "sayılar1'in ref. numarası sayılar2'nin ref. numarasına eşittir." demek istiyor. 
        sayilar2[0] = 999;
        // sayilar1[0] ?? 999
        // bellekte iki alan var. stack ve heap.
        // stack alanında sadece değerler vardır.
        // heap alanında ise referans var. 
    }
}