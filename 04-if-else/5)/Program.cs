namespace _5_;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Birinci kenarı girin: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci kenarı girin: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü kenarı girin: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Bu kenarlar bir üçgen oluşturur.");
        }
        else
        {
            Console.WriteLine("Bu kenarlar bir üçgen oluşturmaz.");
        }
    }
}
