using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalLanguageProcessing
{
    class nlp
    {
        public void reader()
        {
            int[] vf = { 0, 0, 0, 0, 0 };
     
            string input = System.IO.File.ReadAllText("treasureisland.txt");


            Console.WriteLine("The number of characters within the text file: {0}", charNum(input));
            Console.WriteLine("The number of white spaces within the text file: {0}", wsNum(input));
            Console.WriteLine("The number of vowels within the text file: {0}", vowelNum(input));
            Console.WriteLine("The number of consonants within the text file: {0}", consonantNum(input));



            vowelFreq(vf, input);


            Console.WriteLine("The number of 'A' vowels: {0}", vf[0]);
            Console.WriteLine("The number of 'E' vowels: {0}", vf[1]);
            Console.WriteLine("The number of 'I' vowels: {0}", vf[2]);
            Console.WriteLine("The number of 'O' vowels: {0}", vf[3]);
            Console.WriteLine("The number of 'U' vowels: {0}", vf[4]);

            Console.ReadKey();

        }
        public int charNum(string text)
        {
            int num = 0;
            foreach (char c in text)
            {
                if (c != ' ' && c != '\r' && c != '\n')
                {
                    num++;
                }                
            }
            return num;
        }
        public int wsNum(string text)
        {
            int num = 0;
            foreach (char c in text)
            {
                if (c == ' ' || c == '\r' || c == '\n')
                {
                    num++;
                }
            }
            return num;
        }
        public int vowelNum(string text)
        {
            int num = 0;
            //char[] vowel = { 'a', 'e', 'i','o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char c in text)
            {
                if( "aeiouAEIOU".IndexOf(c) >= 0)
                num++; 
            }
            return num;
        }
        public int consonantNum(string text)
        {
            int num = 0;
            foreach (char c in text.ToLower())
            {
                //if (!("aeiouAEIOU ,.!;'\n\r".IndexOf(c) >= 0))
                if ("bcdfghjklmnpqrstvwxyz".IndexOf(c) >= 0)
                        num++;
            }
            return num;
        }
        public void vowelFreq(int[] v, string text)
        {
            int numA = 0, numE = 0, numI = 0, numO = 0, numU = 0;

            foreach (char c in text.ToLower())
            {
                if (c == 'a')
                    numA++;
                else if (c == 'e')
                    numE++;
                else if (c == 'i')
                    numI++;
                else if (c == 'o')
                    numO++;
                else if (c == 'u')
                    numU++;
            }

            v[0] = numA;
            v[1] = numE;
            v[2] = numI;
            v[3] = numO;
            v[4] = numU;


        }
    }
}
