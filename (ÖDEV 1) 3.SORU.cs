﻿int n;
Console.WriteLine("POZİTİF BİR SAYI GİRİNİZ");
Console.Write("N:");
n = Convert.ToInt32(Console.ReadLine());

while(n<=0)
{
    if (n <= 0)
    {
        Console.WriteLine("N SAYISI POZTİF DEĞİLDİR LÜTFEN TEKRAR GİRİNİZ");
        Console.Write("N :");
        n = Convert.ToInt32(Console.ReadLine());
    }
}
string[] dizi = new string[n];
Console.WriteLine("{0} ADET KELİME GİRİNİZ",n);

for(int i=0;i<dizi.Length;i++)
{
    Console.Write("{0}.KELİMEYİ GİRİNİZ : ",i+1);
    dizi[i] = Convert.ToString(Console.ReadLine());
    Console.WriteLine();

    while(dizi[i] == null)
    {
        Console.WriteLine("KELİME GİRDİĞİNİZDEN EMİN OLUN");
        Console.Write("{0}.KELİMEYİ GİRİNİZ", i + 1);
        dizi[i] = Convert.ToString(Console.ReadLine());
        Console.WriteLine();

    }



}

for (int i = 0; i < dizi.Length; i++)
    Console.Write(dizi[i]+"-");
