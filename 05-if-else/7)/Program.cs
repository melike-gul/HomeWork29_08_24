namespace _7_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        char islem = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double sonuc = 0;
        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    Console.WriteLine("Bölme işlemi için ikinci sayı sıfır olamaz!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem!");
                return;
        }

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}
