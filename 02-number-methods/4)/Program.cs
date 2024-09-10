namespace _4_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double karekok = Math.Sqrt(sayi);
        Console.WriteLine("Karekök: " + karekok);
    }
}
