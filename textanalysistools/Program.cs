using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textanalysistools
{
    class Program

    {

        static void Main(string[] args)

        {

            Program a = new Program();

            Console.WriteLine("the lomgest word is: ");

            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for procesing bt an analytical Engine."));



        }

        public string MyFunctionA(string input)

        {

            string[] words = input.Split('');
            int wordArrayLength = words.Length;
            int[]wordsArrayLegth =new int[wordArrayLength];



            foreach (var word in words)

            {
                

            }

            string currentWord = words[0];

            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)

            {

                currentWord = words[y];

                nextWord = words[y + 1];



            }

            return currentWord;

        }

    }

}