

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



    public static void plusMinus(List<int> arr)
    {
        float length = arr.Count();
        float countneg = 0;
        float countpos = 0;
        float countzero = 0;

        foreach (int i in arr)
        {
            if (i > 0)
            {
                countpos++;
            }
            else if (i < 0)
            {
                countneg++;
            }
            else if (i == 0)
            {
                countzero++;
            }
        }

        float a = countpos / length;
        float b = countneg / length;
        float c = countzero / length;

        string bir = a.ToString("0.000000");
        string iki = b.ToString("0.######");
        string uc = c.ToString("0.######");



        Console.WriteLine(bir);
        Console.WriteLine(iki);
        Console.WriteLine(uc);

    }

}



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
