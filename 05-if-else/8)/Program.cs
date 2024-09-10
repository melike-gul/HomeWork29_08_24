namespace _8_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Doğum yılınızı giriniz: ");
        int dogumYili = Convert.ToInt32(Console.ReadLine());

        int kalan = dogumYili % 12;
        string zodyak = kalan switch
        {
            0 => "Maymun",
            1 => "Horoz",
            2 => "Köpek",
            3 => "Domuz",
            4 => "Fare",
            5 => "Öküz",
            6 => "Kaplan",
            7 => "Tavşan",
            8 => "Ejderha",
            9 => "Yılan",
            10 => "At",
            11 => "Koyun",
            _ => "Bilinmiyor"
        };

        Console.WriteLine($"Çin Zodyağı Burcunuz: {zodyak}");
    }
}
