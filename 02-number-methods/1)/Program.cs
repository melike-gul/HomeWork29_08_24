namespace _1_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir ondalıklı sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        int yuvarlanmisSayi = (int)Math.Round(sayi);
        Console.WriteLine("En yakın tam sayı: " + yuvarlanmisSayi);
    }
}
