namespace _3_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double mutlakDeger = Math.Abs(sayi);
        Console.WriteLine("Mutlak değer: " + mutlakDeger);
    }
}
