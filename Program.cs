using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DS_HashTable4
{
    class Program
    {
        static void Main(string[] args)
        {

            //The big o notation for the best case O(n)
            //The big o notaion for the worst case O(n^2)

            try
            {
                //put the contents of the file into a string array
                string[] lines = System.IO.File.ReadAllLines(@"D:\assignment 4\file2.txt");
                //create hashtable
                Hashtable ht = new Hashtable();

                //empty string array "words"
                string[] words;

                for (int i = 0; i < lines.Length; i++)
                {
                    //splits the contents of the lines with space and stores into the empty "words" array
                    words = lines[i].Split(' ');
                    //for each item in words
                    foreach (string word in words)
                    {
                        //if the hashtable already contains the word, increase the counter by 1
                        if (ht.ContainsKey(word))
                        {
                            ht[word] = (int)ht[word] + 1;
                        }
                        //else we are adding the word into the hashtable and value with 1
                        else
                        {
                            ht.Add(word, 1);
                        }
                    }
                }

                //initiate an empty string that will hold the word that was most frequently used 
                //initiate an integer with starting value zero and will hold the number of time the most frequent word was used
                string highString = "";
                int highCount = 0;

                foreach (string key in ht.Keys)
                {
                    //if the count of the word is higher than the "highCount" then it will update the value and become the new value of highCount
                    if ((int)ht[key] > highCount)
                    {
                        highString = key;
                        highCount = (int)ht[key];
                    }
                    else if ((int)ht[key] == highCount)
                    {
                        Console.WriteLine("Most commonly used word: " + highString);
                        Console.WriteLine("Number of times used: {0}", highCount);
                        highString = key;
                    }
                }

                Console.WriteLine("Most commonly used word: " + highString);
                Console.WriteLine("Number of times used: {0}", highCount);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
