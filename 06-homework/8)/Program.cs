namespace _8_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir sayı girin: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 0;

        Console.Write("Fibonacci Serisi: " + a + " " + b);
        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(" " + c);
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}
