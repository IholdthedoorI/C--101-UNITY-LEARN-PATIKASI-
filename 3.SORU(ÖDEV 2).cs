
using System.Collections;

ArrayList Liste = new ArrayList();

string metin;
string sesli_harfler = "aıiuüoöe";

char kontrol;

Console.Write("BİR METİN GİRİNİZ : ");
metin = Console.ReadLine();

metin.ToArray();
sesli_harfler.ToArray();
kontrol = metin[0];

foreach(char i in sesli_harfler)
{
    foreach(char c in metin)
    {
        if (i == c)
        {
            Liste.Add(c);
        }
    }
    
}
Liste.Sort();

foreach(char c in Liste)
{
    Console.Write(c + "-");
}





