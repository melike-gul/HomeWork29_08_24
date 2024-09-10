namespace _3_;

class Program
{
    static void Main(string[] args)
    {
       const double acilisUcreti = 30;
        const double kmBasiUcret = 20;
        const double minUcret = 100;

        Console.Write("Gidilen mesafeyi (km) giriniz: ");
        double mesafe = Convert.ToDouble(Console.ReadLine());

        double toplamUcret = acilisUcreti + (mesafe * kmBasiUcret);
        toplamUcret = toplamUcret < minUcret ? minUcret : toplamUcret;

        Console.WriteLine($"Toplam Taksimetre Ücreti: {toplamUcret} TL");
    }
}
