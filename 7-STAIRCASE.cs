using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    

    public static void staircase(int n)
    {
        int x = n;
        string[,] dizi = new string[x,x];

        for(int i = 0; i < dizi.GetLength(0); i++)
        {
            for(int j =x; n<=j; j--)
            {
                dizi[i, (j-1)] = "#";
            }

            n--;
        }

        for(int i = 0; i<x;i++)
        {
            for(int j = 0; j<x;j++)
            {
                if (dizi[i, j] != "#")
                {
                    dizi[i, j] = " ";
                }

                else
                    continue;
            }
        }

        for(int i = 0; i<x; i++)
        {
            for(int j = 0; j<x;j++)
            {
                Console.Write(dizi[i, j]);

            }
            Console.WriteLine();
        }
     

        
    }

   

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
