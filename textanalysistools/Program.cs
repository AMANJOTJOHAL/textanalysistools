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

        public MyFunctionA(string input)

        {

            string[] words = input.Split('');

            int wordArrayLength = new int[wordArrayLength];



            foreach (var word in words)

            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }


            }

            string currentWord = words[0];

            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)

            {

                currentWord = words[y];

                nextWord = words[y + 1];



            }



        }

    }

}