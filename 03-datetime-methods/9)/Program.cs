﻿namespace _9_;

class Program
{
    static void Main(string[] args)
    {
            Console.Write("İlk tarihi girin (yyyy-MM-dd formatında): ");
            DateTime tarih1 = DateTime.Parse(Console.ReadLine());

            Console.Write("İkinci tarihi girin (yyyy-MM-dd formatında): ");
            DateTime tarih2 = DateTime.Parse(Console.ReadLine());

            if (tarih1 < tarih2)
            {
                Console.WriteLine("İlk tarih ikinci tarihten önce.");
            }
            else if (tarih1 > tarih2)
            {
                Console.WriteLine("İlk tarih ikinci tarihten sonra.");
            }
            else
            {
                Console.WriteLine("İki tarih aynı.");

    }
}
