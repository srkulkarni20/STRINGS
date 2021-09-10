//Your task  is to implement the function atoi.The function takes a string (str) as argument and converts it to an integer and returns it.
using System;
using System.Reflection.Metadata;

namespace Assignment6_7
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "-2147483649";
            int res=0,sign=1;        
            if (s[0]=='-')
              {
                sign = -1;
              }
              int i = sign == 1 ? 0 : 1;
              for (; i < s.Length; i++)
              {

                if (s[i] >= '0' && s[i] <= '9')
                {

                    if (sign == 1 && res == Int32.MaxValue / 10 && s[i] - '0' > 7)
                    {
                        Console.WriteLine("number excedded the int");
                        return;
                    }
                    else if (sign == -1 && res == Int32.MaxValue / 10 && s[i] - '0' > 8)
                    {
                        Console.WriteLine("Less than int  min");
                        return;
                    }



                    res = res * 10 + s[i] - '0';

                }
                else
                {
                    Console.WriteLine("Not a Valid format");
                }                 

              }
          
            Console.WriteLine(res * sign);

            

        }
    }
}
