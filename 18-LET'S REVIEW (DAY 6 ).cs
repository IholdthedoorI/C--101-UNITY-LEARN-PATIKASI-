    using System;
    using System.Collections.Generic;
    using System.IO;
    class Solution 
    {    
        static void Main(String[] args) 
        {
            int kelimesayisi ;
            string str;
            int count;
            int x=1;

            kelimesayisi = Convert.ToInt32(Console.ReadLine());
            string [] dizi = new string[kelimesayisi];
            
            //KULLANICIDAN VERILER ALINMASI VE DIZIYE AKTRAILMASI

            for(int i=0;i<kelimesayisi;i++)
            {
                dizi[i]=Console.ReadLine().ToString();
            }

            //CIKIS DEGERLERINI VEREN DONGULER

            for(int i =0;i<kelimesayisi;i++)
            {
                str = dizi[i].ToString();
                count=str.Count();
                str.ToArray();

                for(int j=0;j<count;j++)
                {
                    if(j==0 || j%2==0)
                    {
                        Console.Write(str[j]);
                    }

                    x++;

                    if(x==count+1)
                    {
                        Console.Write(" ");

                        for(int z = 0 ;z<count;z++)
                        {
                            if(z==1|| z%2==1)
                            {
                                Console.Write(str[z]);
                            }
                        }
                    }


                    

                    
                    
                    
                    
                }

                Console.WriteLine();
                x=1;

            }
        
        }
    }