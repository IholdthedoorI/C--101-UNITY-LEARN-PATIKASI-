
using System.Collections;
using System.Text.RegularExpressions;

NewMethod();

static void NewMethod()
{
    // TANIMLAMALAR
    Regex number = new Regex(@"[0-9]");

    ArrayList Asal = new ArrayList();
    ArrayList AsalOlmayan = new ArrayList();
    List<string> liste = new List<string>();

    int y = 1;
    float toplam_asal = 0;
    float toplam_asalolmayan = 0;

    float ortalama_asal = 0f;
    float ortlama_asalolmayan = 0f;

    bool kontrol;
    bool asal_mi = true;
    bool break_ = false;

    Console.WriteLine("20 ADET POZİTİF TAM SAYI GİRİNİZ");

    Input_fonksiyonu(y);

    //ASAL KONTROL KODU
    foreach (string i in liste)
    {
        int.TryParse(i, out int x);
        for (int j = 2; j < x; j++)
        {
            if (x == 1)
            {
                asal_mi = false;
            }
            if (x == 2)
            {
                asal_mi = true;
            }

            if (x % j == 0)
            {
                asal_mi = false;
                break;
            }
            else
            {
                asal_mi = true;
            }
        }
        ArrayList_add(asal_mi, x);






    }

    //ASALLARIN VE ASAL OLMAYANLARIN ELEMANLARININ TOPLANDIĞI KODLAR
    foreach (int i in Asal)
    {
        toplam_asal += i;


    }
    foreach (int i in AsalOlmayan)
    {
        toplam_asalolmayan += i;

    }

    //ORTALAMALARIN ALINDIĞI KODLAR
    ortalama_asal = toplam_asal / Asal.Count ;
    ortlama_asalolmayan = toplam_asalolmayan / AsalOlmayan.Count;

    //ASAL VE ASAL OLMAYAN SAYILARIN BÜYÜKTEN KÜÇÜĞE SIRALAMASINI SAĞLAYAN KODLAR
    Asal.Sort();
    Asal.Reverse();
    AsalOlmayan.Sort();
    AsalOlmayan.Reverse();

    //ASALLARIN BÜYÜKTEN KÜÇÜĞE VE ORTALMASININ YAZILDIĞI KODLAR
    Console.WriteLine("ASAL");
    foreach (int i in Asal)
    {

        Console.Write(i + ",");


    }
    Console.WriteLine();
    Console.WriteLine("ASAL OLANLARIN ORTLAMASI : " + ortalama_asal);

    Console.WriteLine();

    //ASAL OLMAYANLARIN BÜYÜKTEN KÜÇÜĞE VE ORTALMASININ YAZILDIĞI KODLAR
    Console.WriteLine("NO ASAL");
    foreach (int i in AsalOlmayan)
    {
        Console.Write(i + ",");
    }
    Console.WriteLine();
    Console.WriteLine("ASAL OLMAYANLARIN ORTALAMASI : " + ortlama_asalolmayan);

    //FONKSİYONLAR
    void Input_fonksiyonu(int x)
    {
        for (int i = x; i < 20; i++)
        {
            Console.Write(i + ". SAYIYI GİRİNİZ : ");
            string sayi_tutucu = Console.ReadLine();


            //Input'un negatif ve numeric olmayan girişlerini engeleyen fonksiyona ınput'un gönderildiği kısım.
            Kontrol_fonksiyonu(sayi_tutucu, i);//Veri istenen türde değilse aşağıdaki işlemler gerçekleşmez.
            if (break_)
            {
                break;
            }
            else
            {
                liste.Add(sayi_tutucu);
                continue;
            }
        }

        if (break_)
        {
            break_ = false;
            Input_fonksiyonu(y);
        }


    }
    void Kontrol_fonksiyonu(string str, int i)
    {
        kontrol = number.IsMatch(str);
        if (kontrol)
        {

            if (int.TryParse(str, out int x))
            {
                if (x <= 0)
                {
                    Console.WriteLine("Girdiğiniz veri negatif bir veya nötr bir sayıdır .Lütfen pozitif bir tam sayı giriniz.");
                    y = i;
                    break_ = true;
                }


            }
            else
            {
                Console.WriteLine("Girdiğiniz veri,tam bir sayı değildir .Lütfen pozitif bir tam sayı giriniz.");
                y = i;
                break_ = true;
            }

        }
        else
        {
            Console.WriteLine("Girdiğiniz veri birer sayı değildir.Lütfen pozitif bir tam sayı giriniz");
            y = i;
            break_ = true;
        }
    }
    void ArrayList_add(bool z, int i)
    {
        if (z)
        {
            Asal.Add(i);
        }
        else
        {
            AsalOlmayan.Add(i);
        }
    }
}

