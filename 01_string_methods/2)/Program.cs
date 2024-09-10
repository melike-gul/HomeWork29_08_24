namespace _2_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir metin girin: ");
        string metin = Console.ReadLine();

        string buyukHarfler = metin.ToUpper();
        string kucukHarfler = metin.ToLower();

        Console.WriteLine($"{buyukHarfler}\n{kucukHarfler}");
    }
}
