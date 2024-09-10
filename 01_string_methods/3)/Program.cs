namespace _3_;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();
        
        // Kullanıcıdan aranacak kelimeyi al
        Console.Write("Kaç kez geçtiğini öğrenmek istediğiniz kelimeyi girin: ");
        string kelime = Console.ReadLine();

        // Cümleyi boşluk karakterlerine göre böler ve kelimeleri bir diziye koyar
        string[] kelimeler = cumle.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Belirli bir kelimenin kaç kez geçtiğini say
        int sayac = 0;
        foreach (string k in kelimeler)
        {
            if (k.Equals(kelime, StringComparison.OrdinalIgnoreCase))
            {
                sayac++;
            }
        }

        // Sonucu ekrana yazdır
        Console.WriteLine($"Kelime '{kelime}' cümlede {sayac} kez geçiyor.");
    }
}
