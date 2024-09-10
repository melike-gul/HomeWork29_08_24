namespace _6_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir harf notu girin (A, B, C, D, F): ");
        char not = char.Parse(Console.ReadLine().ToUpper());

        switch (not)
        {
            case 'A':
            case 'B':
            case 'C':
            case 'D':
                Console.WriteLine("Geçti");
                break;
            case 'F':
                Console.WriteLine("Kaldı");
                break;
            default:
                Console.WriteLine("Geçersiz bir not girdiniz.");
                break;
    }
}
