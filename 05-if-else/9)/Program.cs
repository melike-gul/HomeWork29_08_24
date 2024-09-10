namespace _9_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Yılı giriniz: ");
        int yil = Convert.ToInt32(Console.ReadLine());

        bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);

        Console.WriteLine(artikYil ? $"{yil} bir artık yıldır." : $"{yil} bir artık yıl değildir.");
    }
}
