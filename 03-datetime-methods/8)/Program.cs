namespace _8_;

class Program
{
    static void Main(string[] args)
    {
        DateTime simdikiTarih = DateTime.Now;
        string ayAdi = simdikiTarih.ToString("MMMM");
        Console.WriteLine("Bu ay: " + ayAdi);
    }
}
