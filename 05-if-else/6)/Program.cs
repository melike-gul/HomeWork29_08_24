namespace _6_;

class Program
{
    static void Main(string[] args)
    {
        const double armutFiyat = 45.50;
        const double bamyaFiyat = 81.40;
        const double domatesFiyat = 45.00;
        const double muzFiyat = 65.00;
        const double patlicanFiyat = 45.00;

        Console.Write("Armut kaç kilo? ");
        double armutKilo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bamya kaç kilo? ");
        double bamyaKilo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Domates kaç kilo? ");
        double domatesKilo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Muz kaç kilo? ");
        double muzKilo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Patlıcan kaç kilo? ");
        double patlicanKilo = Convert.ToDouble(Console.ReadLine());

        double toplamTutar = (armutKilo * armutFiyat) +
                             (bamyaKilo * bamyaFiyat) +
                             (domatesKilo * domatesFiyat) +
                             (muzKilo * muzFiyat) +
                             (patlicanKilo * patlicanFiyat);

        Console.WriteLine($"Toplam Tutar: {toplamTutar} TL");
    }
}
