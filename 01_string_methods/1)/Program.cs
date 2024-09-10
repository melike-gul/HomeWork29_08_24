namespace _1_;

class Program
{
    static void Main()
    {
       
        Console.Write("Bir cümle girin: ");
        string sentence = Console.ReadLine();
        
        
        int sentenceNumber = SentenceNumber(sentence);
        
        
        Console.WriteLine("Kelime sayısı: " + sentenceNumber);
    }

    static int SentenceNumber(string sentence)
    {
      
        string[] kelimeler = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        return kelimeler.Length;
    }
}
