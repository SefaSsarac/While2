using System;

class Program
{
    static void Main()
    {
        int baslangic = 51;
        int bitis = 150;
        int toplam = 0;
        int sayi = baslangic;

        while (sayi < bitis)
        {
            toplam += sayi;
            sayi++;
        }

        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);
    }
}