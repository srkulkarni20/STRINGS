using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_9
{
    public class LongestCommonPrefix
    {
        static readonly int ALPHABET_SIZE = 26;

        public class TrieNode
        {
            public TrieNode[] children = new TrieNode[ALPHABET_SIZE];

            // isLeaf is true if the node represents 
            // end of a word 
            public bool isLeaf;

            // constructor 
            public TrieNode()
            {
                isLeaf = false;
                for (int i = 0; i < ALPHABET_SIZE; i++)
                    children[i] = null;
            }
        };
        static TrieNode root;
        static int indexs;

       public static void insert(String key)
        {
            int length = key.Length;
            int index;

            TrieNode pCrawl = root;

            for (int level = 0; level < length; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.children[index] == null)
                    pCrawl.children[index] = new TrieNode();

                pCrawl = pCrawl.children[index];
            }

            // mark last node as leaf 
            pCrawl.isLeaf = true;
        }

        public static int countChildren(TrieNode node)
        {
            int count = 0;
            for (int i = 0; i < ALPHABET_SIZE; i++)
            {
                if (node.children[i] != null)
                {
                    count++;
                    indexs = i;
                }
            }
            return (count);
        }

        public static String walkTrie()
        {
            TrieNode pCrawl = root;
            indexs = 0;
            String prefix = "";

            while (countChildren(pCrawl) == 1 &&
                    pCrawl.isLeaf == false)
            {
                pCrawl = pCrawl.children[indexs];
                prefix += (char)('a' + indexs);
            }
            return prefix;
        }

        // A Function to construct trie 
        public static void constructTrie(String[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                insert(arr[i]);
            return;
        }

        // A Function that returns the longest common prefix 
        // from the array of strings 
        public static String commonPrefix(String[] arr, int n)
        {
            root = new TrieNode();
            constructTrie(arr, n);

            // Perform a walk on the trie 
            return walkTrie();
        }

    }
}
