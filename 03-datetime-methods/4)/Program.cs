namespace _4_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İlk tarihi girin (yyyy-MM-dd formatında): ");
        DateTime tarih1 = DateTime.Parse(Console.ReadLine());

        Console.Write("İkinci tarihi girin (yyyy-MM-dd formatında): ");
        DateTime tarih2 = DateTime.Parse(Console.ReadLine());

        TimeSpan fark = tarih2 - tarih1;
        Console.WriteLine("İki tarih arasındaki gün farkı: " + fark.Days);
    }
}
