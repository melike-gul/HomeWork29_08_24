namespace _8_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        // Doğal logaritmayı hesapla
        double logaritma = Math.Log(sayi);
        Console.WriteLine("Doğal logaritma: " + logaritma);
    }
}
