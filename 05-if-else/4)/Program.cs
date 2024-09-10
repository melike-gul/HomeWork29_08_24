namespace _4_;

class Program
{
    static void Main(string[] args)
    {
        const double pi = 3.14159;

        Console.Write("Yarıçapı giriniz: ");
        double yaricap = Convert.ToDouble(Console.ReadLine());

        double alan = pi * yaricap * yaricap;
        double cevre = 2 * pi * yaricap;

        Console.WriteLine($"Dairenin Alanı: {alan}");
        Console.WriteLine($"Dairenin Çevresi: {cevre}");
    }
}
