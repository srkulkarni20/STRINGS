
//Given a array of Nstrings, find the longest common prefix among all strings present in the array.

using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Assignment6_9
{


   
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] str = { "April", "ap", "Apple" };
            string prefix= findprefix(str);
            Console.WriteLine(prefix);
        }


        static int  find_min( string[] str)
        {
            int minlen = str[0].Length;
           
            for(int i=0;i<str.Length;i++)
            {
                if(minlen > str[i].Length)
                {
                    minlen = str[i].Length;
                   
                }

            }
            return minlen;

        }

       static string findprefix(string[] str)
        {
            int minlen = find_min(str);
            string prefix = string.Empty;
            for (int i=0;i<minlen;i++)
            {
                char curr = str[0][i];
                for(int j=0;j<str.Length;j++)
                {

                    if(curr==str[j][i] || curr+32 == str[j][i] || curr == str[j][i]+32)
                    {
                        continue;
                    }
                    else
                    {
                        return prefix;
                        
                    }
                    
                }
                prefix += curr;
            }
            return prefix;
        }
    }
}
