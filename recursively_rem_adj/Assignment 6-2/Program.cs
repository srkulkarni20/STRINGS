//Given a string, recursively remove adjacent duplicate characters from string. The output string should not have any adjacent duplicates. See following examples.
//Input:  azxxzy
//Output: ay

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;

namespace Assignment_6_2
{
    class Program
    {
        static public string remove(string inpstr, int length)
        {     

            if (length == 0)
            {              
                return inpstr[length].ToString();
            }
          

            string finalstr = remove(inpstr, length - 1);

            if ((finalstr.Length>0 && finalstr[finalstr.Length - 1] == inpstr[length]) 
                ||  inpstr[length] == inpstr[length- 1])
            {
                if (finalstr.Length > 0  && finalstr[finalstr.Length - 1] == inpstr[length])
                {
                   finalstr= finalstr.Remove(finalstr.Length - 1, 1);
                }             
               
            }
            else
            {
                finalstr = finalstr + inpstr[length];
               

            }

            return finalstr;
        }



        static void Main(string[] args)
        {
            string inpstr = "aaazxxzy";
            string newstr;
            newstr = remove(inpstr,inpstr.Length- 1);

            Console.WriteLine(newstr);
          
           
            

        }
    }
}
