namespace _4_;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;
        Console.Write("Çarpanlar: ");
        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                toplam += i;
                Console.Write(i + " ");
            }
        }
        Console.WriteLine($"\nÇarpanların Toplamı: {toplam}");
    }
}
