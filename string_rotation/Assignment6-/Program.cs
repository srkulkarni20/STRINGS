/*Given two strings, the task is to find if a string ('a') can be obtained by rotating another string ('b') by two places.
Examples:
Input : a = "amazon"         b = "azonam"  // rotated anti-clockwise

Output : True

Input : a = "amazon"        b = "onamaz"  // rotated clockwise*/


using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment6_
{
    class Program
    {
       static public string substr(string s,int start_index,int count)
        {

            string newstr = string.Empty;
            for(int i=start_index ; i<start_index+count;i++)
            {
                newstr = newstr + s[i];

            }
            return newstr;
        }
        
        static void Main(string[] args)
        {
            string a = "amazon";
            string b = "onamaz";
            string c = "azonam";


            string rot_clk = substr(c, c.Length - 2, 2) + substr(c, 0, c.Length - 2);
            string rot_anticlk = substr(b, 2, b.Length - 2) + substr(b, 0, 2);
            Console.WriteLine(rot_clk);
            Console.WriteLine(rot_anticlk);


        }

        
    }


}
