namespace _3_;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Bir karakter girin: ");
        char karakter = Convert.ToChar(Console.ReadLine().ToLower());

        if (karakter == 'a' || karakter == 'e' || karakter == 'i' || karakter == 'o' || karakter == 'u')
        {
            Console.WriteLine("Karakter sesli harf.");
        }
        else
        {
            Console.WriteLine("Karakter sessiz harf.");
        }
    }
}
