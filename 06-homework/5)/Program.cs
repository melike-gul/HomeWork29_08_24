namespace _5_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        string sayi = Console.ReadLine();

        char[] ters = sayi.ToCharArray();
        Array.Reverse(ters);

        string tersSayi = new string(ters);
        Console.WriteLine($"Ters Sayı: {tersSayi}");
    }
}
