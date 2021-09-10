//Given two strings ‘X’ and ‘Y’, find the length of the longest common substring.

using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Assignment6_5
{
    class Program
    {
        public static void find_long_substring(string X,string Y)
        {
            int[,] res = new int[X.Length+ 1, Y.Length+ 1];
            int maxlength = 0, index_row = 0;

            for(int i=0;i<=Y.Length;i++)
            {
                for (int j = 0; j <= X.Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        res[j, i] = 0;
                    }

                    else if (X[j - 1] == Y[i - 1])
                    {
                        res[j, i] = res[j - 1, i - 1] + 1;
                        if (res[j, i] > maxlength)
                        {
                            maxlength = res[j, i];
                            index_row = j;
                            
                        }
                    }
                    else
                    {
                        res[j, i] = 0;
                    }
                }

            }
            string res_str=string.Empty;
            Console.WriteLine(maxlength + "Maxlength");
            while(maxlength>0)
            {
                res_str =  X[index_row - 1]+ res_str ;
                index_row--;
                maxlength--;
            }
            Console.WriteLine(res_str + "Maxlength");

        }

        static void Main(string[] args)
        {
            string X = "GeeksforGeeks";
            string Y = "GeeksQuiz";

            find_long_substring(X, Y);
        }
    }
}
