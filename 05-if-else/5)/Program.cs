namespace _5_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Boyunuzu metre cinsinden girin (örneğin 1,75): ");
        double boy = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kilonuzu girin: ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        double vki = kilo / (boy * boy);

        Console.WriteLine($"Vücut Kitle İndeksiniz: {vki}");
    }
}
