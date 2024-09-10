namespace _5_;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Bir tarih girin (yyyy-MM-dd formatında): ");
        DateTime tarih = DateTime.Parse(Console.ReadLine());

        int gunSayisi = tarih.DayOfYear;
        Console.WriteLine("Tarih yılın {0}. günü", gunSayisi);
    }
}
