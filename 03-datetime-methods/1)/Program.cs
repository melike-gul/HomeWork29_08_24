namespace _1_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tarih girin (yyyy-MM-dd formatında): ");
        DateTime tarih = DateTime.Parse(Console.ReadLine());
        DayOfWeek gun = tarih.DayOfWeek;
        Console.WriteLine("Tarih haftanın günü: " + gun);
    }
}
