namespace _3_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir sayı girin: ");
        string sayi = Console.ReadLine();

        char[] rakamlar = sayi.ToCharArray();
        Array.Sort(rakamlar);

        Console.WriteLine("Sıralı Rakamlar: " + string.Join(",", rakamlar));
    }
}
