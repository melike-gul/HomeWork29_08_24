namespace _6_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        int bolenSayisi = 0;
        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                bolenSayisi++;
            }
        }
        Console.WriteLine($"Pozitif Bölen Sayısı: {bolenSayisi}");
    }
}
