namespace _7_;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Bir açı (derece cinsinden) girin: ");
        double derece = Convert.ToDouble(Console.ReadLine());

        // Dereceyi radyan cinsine dönüştür
        double radyan = derece * (Math.PI / 180);
        Console.WriteLine("Radyan cinsinden açı: " + radyan);
    }
}
