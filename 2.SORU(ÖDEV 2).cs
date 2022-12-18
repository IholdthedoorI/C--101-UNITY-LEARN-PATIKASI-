using System.Collections;

//TANIMLAMALAR
List<int> Sayilar = new List<int>();
List<int> Sayilar2 = new List<int>();

ArrayList enbuyukleri = new ArrayList();
ArrayList enkucukleri = new ArrayList();

int en_buyuk = 0;
int en_kucuk = 0;
float ortlama_B = 0;
float ortlama_K = 0;

Console.WriteLine("20 ADET SAYI GİRİNİZ");

try
{
    //GİRİŞ KISMI
    for (int i = 0; i < 5; i++)
    {
        Console.Write(i+1 + ". SAYI : ");
        Sayilar.Add(Convert.ToInt32(Console.ReadLine()));
        Sayilar2.Add(Sayilar[i]);

    }
    
    //EN BÜYÜK 3 TANESİNİ BULAN KISIM
    for(int i=0;i<3;i++)
    {
        int deneme = Sayilar[0];
        for(int j=1;j<Sayilar.Count;j++)
        {
            if (deneme > Sayilar[j])
            {
                en_buyuk = deneme;         // 1 3 2  6  denem 6 en buyuk 6
            }

            else
            {
                deneme = Sayilar[j];
                en_buyuk= Sayilar[j];
            }
        }

        Sayilar.Remove(en_buyuk);
        enbuyukleri.Add(en_buyuk);
        
    }

    //EN KÜÇÜK 3 TANESİNİ BULAN KISIM
    for (int i = 0; i < 3; i++)
    {
        int deneme = Sayilar2[0];
        for (int j = 1; j < Sayilar2.Count; j++)  // 2 3 1 6 7 deneme 1 en kucuk 1  
        {
            if (deneme < Sayilar2[j])
            {
                en_kucuk = deneme;
            }

            else
            {
                deneme= Sayilar2[j];
                en_kucuk = Sayilar2[j];
            }
        }

        Sayilar2.Remove(en_kucuk);
        enkucukleri.Add(en_kucuk);
    }

    Console.WriteLine();

    enbuyukleri.Sort();
    enkucukleri.Sort();

    //TOPLAMLARININ ALINDIĞI KISIM
    foreach(int i in enbuyukleri)
    {
        ortlama_B += i;
    }
    foreach(int i in enkucukleri)
    {
        ortlama_K += i;
    }

    //İSTENEN SONUÇ (ORTALAMALARI)
    Console.WriteLine("EN BÜYÜK 3 TANESİNİN ORTALAMASI : " + ortlama_B / 3);
    Console.WriteLine("EN KÜÇÜK 3 TANESİNİN ORTALAMASI : " + ortlama_K / 3);
}

catch(Exception ex)
{  
    Console.WriteLine(ex.Message);
}

