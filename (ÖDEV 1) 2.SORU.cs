try
{

    int m;
    int n;


    Console.WriteLine("POZİTİF İKİ SAYI GİRİNİZ");
    Console.Write("N :");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("M : ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    while (n <= 0 || m <= 0)
    {
        if (n <= 0 || m <= 0)
        {
            if (n <= 0)
            {
                Console.WriteLine("N SAYISI POZTİF DEĞİLDİR LÜTFEN TEKRAR GİRİNİZ");
                Console.Write("N :");
                n = Convert.ToInt32(Console.ReadLine());
            }

            if (m <= 0)
            {
                Console.WriteLine("M SAYISI POZTİF DEĞİLDİR LÜTFEN TEKRAR GİRİNİZ");
                Console.Write("M : ");
                m = Convert.ToInt32(Console.ReadLine());

            }
        }
    }

    int[] dizi = new int[n];

    Console.WriteLine("{0} ADET SAYI GİRİNİZ", n);
    Console.WriteLine();

    for (int i = 0; i < dizi.Length; i++)
    {
        Console.Write("{0}.SAYIYI GİRİNİZ :", i+1);
        dizi[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }

    for (int i = 0; i < dizi.Length; i++)
    {
        if (dizi[i] == m || dizi[i] % m == 0)
            Console.Write(dizi[i] + "-");
    }








}

catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
