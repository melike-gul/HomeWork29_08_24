namespace _6_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir açı (derece cinsinden) girin: ");
        double derece = Convert.ToDouble(Console.ReadLine());

        // Dereceyi radyan cinsine dönüştür
        double radyan = derece * (Math.PI / 180);
        
        // Sinüs değerini hesapla
        double sinus = Math.Sin(radyan);
        Console.WriteLine("Sinüs değeri: " + sinus);
    }
}
