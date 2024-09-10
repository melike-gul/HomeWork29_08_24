namespace _1_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());
        
        var katlar = Enumerable.Range(0, sayi + 1)
                               .Where(x => x % 3 == 0 && x % 4 == 0)
                               .ToList();

        if (katlar.Count > 0)
        {
            double ortalama = katlar.Average();
            Console.WriteLine($"0'dan {sayi}'ya kadar olan sayıların hem 3 hem de 4'e bölünenlerin ortalaması: {ortalama}");
        }
        else
        {
            Console.WriteLine($"0'dan {sayi}'ya kadar hem 3 hem de 4'e bölünen sayı yok.");
        }
    }
}
