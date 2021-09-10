//Given a string S, find the longest palindromic substring in S.
//Input: "babad"  Output: "bab"


using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment6_1
{
    class Program
    {
        static public string find_longest_paliandrome(string s)
        {
            if (s == null || s.Length < 1)
            {
                return "";
            }
            int len_even = 0;
            int len_odd = 0;
            int end = 0;
            int start = 0;
            for(int i=0; i<s.Length;i++)
            {
                len_odd = expandaroundcenter(s,i,i);
                len_even = expandaroundcenter(s,i,i+1);
                Console.WriteLine(len_even + "length even"+i);
                Console.WriteLine(len_odd +"length odd"+i);

                int len = Math.Max(len_even, len_odd);
               
                if (len > end - start)
                 {
                        start = i - (len - 1) / 2;  //because of odd even
                        end = i + len / 2;
                 }

                
            }


            return s.Substring(start, end - start + 1);

        }

        static public int expandaroundcenter(string s,int low,int high)
        {
            int l = low, r= high;
            while(l>=0 && r<s.Length && s[l]==s[r])
            {
                l--;
                r++;
            }

            return r - l - 1;
        }


        static void Main(string[] args)
        {
            string s = "xgjy";

           string pal= find_longest_paliandrome(s);
            Console.WriteLine(pal);
           

        }
    }
}
