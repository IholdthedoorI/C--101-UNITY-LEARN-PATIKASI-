using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";



        int x;
        double y;
        string z;


        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());
        z = Console.ReadLine();
        double toplam = d + y;




        string y1 = toplam.ToString("0.0");

        Console.WriteLine(i + x);
        Console.WriteLine(y1);
        Console.WriteLine(s + z);
    }
}