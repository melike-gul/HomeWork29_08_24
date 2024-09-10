namespace _7_;

class Program
{
    static void Main(string[] args)
    {
            Console.Write("Bir tarih girin (dd/MM/yyyy formatında): ");
        string tarihString = Console.ReadLine();

        DateTime tarih = DateTime.ParseExact(tarihString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Tarih: " + tarih.ToString("yyyy-MM-dd"));
    }
}
