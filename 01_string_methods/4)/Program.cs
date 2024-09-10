namespace _4_;

class Program
{
    static void Main(string[] args)
    {
            Console.Write("Bir cümle girin: ");
            string cumle = Console.ReadLine();

        
            string temizlenmisCumle = cumle.Trim();

        
            Console.WriteLine("Temizlenmiş cümle: \"" + temizlenmisCumle + "\"");
    }
}
