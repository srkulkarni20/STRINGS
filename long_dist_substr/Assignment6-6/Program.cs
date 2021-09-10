
//Given a string, find length of the longest substring with all distinct characters.
//For example, for input "abca", the output is 3 as "abc" is the longest substring with all distinct characters.
using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment6_6
{
    class Program
    {
        
        static void find_longest_substr(string str)
        {
            int i = 0, j = 0, k = 0, len;
            bool duplicate=true;

            string substr = string.Empty;
            substr=substr+ str[i];
            len = substr.Length;
            
            for(i=1;i<str.Length;i++)
            {
                    k = 0;
                    len = substr.Length;
                    while (len>0 && substr[k] != str[i])
                    {
                        duplicate = false;
                        len--;
                    }
                    if(duplicate==false)
                    {
                      substr = substr + str[i];
                      
                    }
                                   
                   
                
             }



            


        }
        
        static void Main(string[] args)
        {

            string str = "ABDEFGABEF";

            find_longest_substr(str);





        }



    }
}
