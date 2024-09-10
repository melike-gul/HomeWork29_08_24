namespace _1_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 0)
        {
            Console.WriteLine("Sayı pozitif.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine("Sayı negatif.");
        }
        else
        {
            Console.WriteLine("Sayı sıfır.");
    }
}
