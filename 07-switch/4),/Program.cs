namespace _4__;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir harf girin: ");
        char harf = char.Parse(Console.ReadLine().ToLower());

        switch (harf)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'ı':
            case 'o':
            case 'ö':
            case 'u':
            case 'ü':
                Console.WriteLine($"{harf} sesli bir harftir.");
                break;
            default:
                Console.WriteLine($"{harf} sessiz bir harftir.");
                break;
    }
}
