namespace _3_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = double.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = double.Parse(Console.ReadLine());

        Console.Write("İşlemi seçin (+, -, *, /): ");
        char islem = char.Parse(Console.ReadLine());

        double sonuc = 0;

        switch (islem)
        {
            case '+': sonuc = sayi1 + sayi2; break;
            case '-': sonuc = sayi1 - sayi2; break;
            case '*': sonuc = sayi1 * sayi2; break;
            case '/': 
                if (sayi2 != 0)
                    sonuc = sayi1 / sayi2; 
                else 
                    Console.WriteLine("Bölme işleminde bölen 0 olamaz!"); 
                break;
            default: Console.WriteLine("Geçersiz bir işlem girdiniz."); break;
        }

        if (islem == '/' && sayi2 == 0)
            return;

        Console.WriteLine($"Sonuç: {sonuc}");
    }
}
