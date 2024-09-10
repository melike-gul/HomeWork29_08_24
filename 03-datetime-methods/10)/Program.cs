namespace _10_;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Bir saati girin (12 saat formatında, örn: 2:30 PM): ");
        string saat12 = Console.ReadLine();

        DateTime saat24 = DateTime.Parse(saat12);
        string saat24Format = saat24.ToString("HH:mm");

        Console.WriteLine("24 saat formatında saat: " + saat24Format);
    }
}
