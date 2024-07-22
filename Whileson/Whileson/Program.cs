using System;

class Program
{
    static void Main()
    {
        int baslangic = 2;
        int bitis = 120;
        int toplam = 0;
        int sayi = baslangic;

        while (sayi < bitis)
        {
            if (sayi % 2 == 0) // Çift sayı kontrolü
            {
                toplam += sayi;
            }
            sayi++;
        }

        Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {toplam}");
    }
}