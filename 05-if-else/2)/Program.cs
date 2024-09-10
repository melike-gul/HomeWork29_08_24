namespace _2_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci kenar uzunluğunu girin: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci kenar uzunluğunu girin: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçüncü kenar uzunluğunu girin: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double s = (a + b + c) / 2;
        double alan = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Console.WriteLine($"Üçgenin alanı: {alan}");
    }
    
}

