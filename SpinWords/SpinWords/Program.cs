using System;

/// <summary>
/// 
/// Stop gninnipS My sdroW!
/// 
/// https://www.codewars.com/kata/5264d2b162488dc400000001
/// 
/// </summary>
/// 


namespace SpinWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sentence = "This is another test";
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 5)
                {
                    string reverse = "";
                    for (int j = 0; j < (words[i].Length); j++)
                    {
                        reverse = reverse + words[i][words[i].Length - 1 - j];
                    }
                    words[i] = reverse;
                }
            }
            sentence = "";
            for (int i = 0; i < words.Length; i++)
                sentence = sentence + " " + words[i];
            Console.WriteLine(sentence);
        }
    }
}


