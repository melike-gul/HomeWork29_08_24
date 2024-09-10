namespace _5_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Tabanı girin: ");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üs değerini girin: ");
        double us = Convert.ToDouble(Console.ReadLine());

        double sonuc = Math.Pow(taban, us);
        Console.WriteLine("{0} üzeri {1} = {2}", taban, us, sonuc);
    }
}
