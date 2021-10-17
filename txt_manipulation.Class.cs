using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace lab4
{
    class txt_manipulation_Class
    {
        public string txt;

        public void readFile() {
            txt = System.IO.File.ReadAllText("text_lab4.txt");
            System.Console.WriteLine(" Textul :\n{1}\n",txt.Length, txt);
        }
        public void nr_sentences() 
        {
            string[] sentences = txt.Split('.');
            int senten = sentences.Length;
            Console.WriteLine(" Number of sentences: {0} ", senten-1);
        }

        public void nr_words() 
        {
            string[] words = txt.Split(' ');
            int word = words.Length;
            Console.WriteLine(" Number of words: {0} ", word);
            
        }

        public void nr_letters() //nr de cuvinte = consoane + vocale
        {
            int vowel = 0;
            int consonant = 0;
            int len = txt.Length;

            for(int i = 0; i < len; i++)
            {

                if(txt[i] =='a' || txt[i]=='e' || txt[i]=='i' || txt[i]=='o' || txt[i]=='u' || txt[i]=='A' || txt[i]=='E' || txt[i]=='I' || txt[i]=='O' || txt[i]=='U')
                {
                    vowel++;
                }
                else if((txt[i]>='a' && txt[i]<='z') || (txt[i]>='A' && txt[i]<='Z'))
                {
                    consonant++;
                }
            }
            Console.WriteLine(" Number of letters: {0} \n   consonants: {1}\n   vowels: {2}", consonant+vowel, consonant, vowel);
        }

        public void top5words()
        {
            var value = txt.Split(' '); // Split the string using 'Space' and stored it an var variable
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            
            for(int i = 0; i < value.Length; i++ )//loop the splited string  
            {
                if(RepeatedWordCount.ContainsKey(value[i]))// Check if word already exist in dictionary 
                {
                    int val = RepeatedWordCount[value[i]];
                    RepeatedWordCount[value[i]] = val + 1; //update the count
                }
                else
                {
                    RepeatedWordCount.Add(value[i], 1);// adding word if it is repeated and not added in dictionary 
                }   
            } 
            Console.WriteLine("\n Top 5 words:"); 
            int count = 1; 
            //KeyValuePair joins 2 things together.
            foreach (KeyValuePair<string, int> item in RepeatedWordCount.OrderByDescending(key => key.Value))  
            {  
                if(item.Value > 1)
                {
                    Console.WriteLine("  {0}) {1} = {2}",count, item.Key, item.Value); //Print the Repeated word and its count 
                    count++; 
                }
                if (count == 6) break; 
            }  
        }

        public void longestWord()
        {
            txt = txt.Replace(".", "");
            txt = txt.Replace(",", "");
            var text = txt.Split(' ');

            var longest = "";
            foreach(var item in text)
            {
                if(item.Length > longest.Length)
                    longest = item;
            }
            Console.WriteLine("\n Longest word: {0}\n" ,longest);
        }
    }
}