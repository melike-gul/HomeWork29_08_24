namespace _7_;

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

        int enBuyuk = Math.Max(sayi1, Math.Max(sayi2, sayi3));
        Console.WriteLine("En büyük sayı: " + enBuyuk);
    }
}
