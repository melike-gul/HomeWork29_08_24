namespace _2_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double buyukSayi = Math.Max(sayi1, sayi2);
        Console.WriteLine("Daha büyük sayı: " + buyukSayi);
    }
}
