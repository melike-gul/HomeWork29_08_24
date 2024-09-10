namespace _2_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        int[] sayilar = { sayi1, sayi2, sayi3 };
        Array.Sort(sayilar);
        Array.Reverse(sayilar);

        Console.WriteLine("Büyükten küçüğe sıralama: " + string.Join(", ", sayilar));
    }
}
