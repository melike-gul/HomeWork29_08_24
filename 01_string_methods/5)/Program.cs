namespace _5_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen ana metni girin: ");
        string anaMetin = Console.ReadLine();
        
        // Kullanıcıdan arama metnini alın
        Console.Write("Lütfen arama metnini girin: ");
        string aramaMetni = Console.ReadLine();
        
        // Arama metnini ana metin içinde arayın
        int index = anaMetin.IndexOf(aramaMetni);
        
        // Sonucu yazdırın
        if (index != -1)
        {
            Console.WriteLine("Arama metni ilk olarak {0} indeksinde bulundu.", index);
        }
        else
        {
            Console.WriteLine("Arama metni ana metin içinde bulunamadı.");
        }
    }
}
