//Given an string in roman no format(s)  your task is to convert it to integer.

using System;
using System.Collections.Generic;

namespace Assignment6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> roman = new Dictionary<char, int>()
                { {'I',1},
                  {'V',5 },
                  {'X', 10},
                  {'L',50},
                  {'C',100},
                  {'D',500 },
                  {'M',1000 },             
                };


            string s;
            s = "XIV";
            
            int val=0;
            int prev_num = 0;
            int final_num = 0;
           

            for(int i=0; i<s.Length; i++)
            {
                try
                {
                    val = roman[s[i]];
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid Roman Number");
                    return;
                }
                if (prev_num >= val)
                {
                    final_num = final_num + val;
                }
                if(prev_num<val)
                {
                    int temp = val - prev_num;
                    final_num = final_num - prev_num;
                    final_num = final_num + temp;
                }
                prev_num = val;
                
                
            }

            Console.WriteLine(final_num);




        }
    }
}
