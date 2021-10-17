using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            txt_manipulation_Class txt = new txt_manipulation_Class();
            txt.readFile();
            txt.nr_sentences();
            txt.nr_words();
            txt.nr_letters();
            txt.top5words();
            txt.longestWord();
        }
    }
}
