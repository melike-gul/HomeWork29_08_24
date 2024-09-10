namespace _1_;

class Program
{
    static void Main(string[] args)
    {Console.Write("Lütfen para tutarını giriniz: ");
        double tutar = Convert.ToDouble(Console.ReadLine());

        double kdvOrani = (tutar > 0 && tutar <= 1000) ? 0.20 : 0.08;
        double kdvTutari = tutar * kdvOrani;
        double kdvliFiyat = tutar + kdvTutari;

        Console.WriteLine($"KDV Tutarı: {kdvTutari} TL");
        Console.WriteLine($"KDV'li Fiyat: {kdvliFiyat} TL");
    }
}
