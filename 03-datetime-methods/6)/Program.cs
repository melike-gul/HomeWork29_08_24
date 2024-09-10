namespace _6_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir yıl girin: ");
        int yil = Convert.ToInt32(Console.ReadLine());

        bool artikYilMi = DateTime.IsLeapYear(yil);
        Console.WriteLine("Girdiğiniz yıl artık yıl mı? " + (artikYilMi ? "Evet" : "Hayır")); } }
    }
}
