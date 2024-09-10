namespace _6_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir not girin: ");
        int not = Convert.ToInt32(Console.ReadLine());

        char harf;
        if (not >= 90)
        {
            harf = 'A';
        }
        else if (not >= 80)
        {
            harf = 'B';
        }
        else if (not >= 70)
        {
            harf = 'C';
        }
        else if (not >= 60)
        {
            harf = 'D';
        }
        else
        {
            harf = 'F';
        }

        Console.WriteLine("Harf karşılığı: " + harf);
    }
}
