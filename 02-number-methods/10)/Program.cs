namespace _10_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir ondalıklı sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ondalık basamak sayısını girin: ");
        int basamakSayisi = Convert.ToInt32(Console.ReadLine());

        double yuvarlanmisSayi = Math.Round(sayi, basamakSayisi);
        Console.WriteLine("Yuvarlanmış sayı: " + yuvarlanmisSayi);
    }
}
