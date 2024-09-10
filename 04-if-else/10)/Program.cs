namespace _10_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        bool asal = true;

        if (sayi <= 1)
        {
            asal = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asal = false;
                    break;
                }
            }
        }

        Console.WriteLine(sayi + " sayısı " + (asal ? "asal" : "asal değil"));
    }
}
