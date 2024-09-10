namespace _4_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir yıl girin: ");
        int yil = Convert.ToInt32(Console.ReadLine());

        bool artikYilMi = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);

        if (artikYilMi)
        {
            Console.WriteLine("Girdiğiniz yıl artık yıl.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz yıl artık yıl değil.");
        }
    }
}
