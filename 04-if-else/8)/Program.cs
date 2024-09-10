namespace _8_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 3 == 0 && sayi % 5 == 0)
        {
            Console.WriteLine("Sayı hem 3'e hem de 5'e tam bölünür.");
        }
        else
        {
            Console.WriteLine("Sayı hem 3'e hem de 5'e tam bölünmez.");
        }
    }
}
