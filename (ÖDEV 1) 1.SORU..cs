﻿try
{
    int kullanicin_sayisi;
    Console.WriteLine("BİR SAYI GİRİNİZ");
    kullanicin_sayisi = Convert.ToInt32(Console.ReadLine());

    int[] dizi = new int[kullanicin_sayisi];

    Console.WriteLine("{0} TANE SAYI GİRECEKSİNİZ", kullanicin_sayisi);

    for (int i = 0; i < dizi.Length; i++)
    {
        Console.WriteLine("{0}. SAYIYI GİRİNİZ ", i + 1);
        dizi[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < dizi.Length; i++)
    {
        if (dizi[i] % 2 == 0)
        {
            Console.Write(dizi[i] + "-");
        }

    }
}

catch(Exception e)
{
    Console.WriteLine(e.Message);

}
