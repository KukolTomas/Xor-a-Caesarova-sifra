using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifrovani
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Pokudhledatepomocnourukunajdetejinakoncipaze";
            string key = "PRAVDA";
            char[] charArr = new char[text.Length];
            char[] decharArr = new char[text.Length];

            string rndText = "nahodnytext";
            char[] originalTextArray = new char[rndText.Length];
            char[] decodedOriginalTextArray = new char[rndText.Length];
            int move = 7;

            //Xor zasifrovani
            for (int i = 0; i < text.Length; i++)
            {
                charArr[i] = (char)(text[i] ^ key[i % key.Length]);
            }
            //Xor desifrovani
            for (int i = 0; i < text.Length; i++)
            {
                decharArr[i] = (char)(charArr[i] ^ key[i % key.Length]);
            }
            // Cesarova sifra - zasifrovani
            for (int i = 0; i < rndText.Length; i++)
            {
                originalTextArray[i] = rndText[i];
            }
            for (int i = 0; i < rndText.Length; i++)
            {
                int reset = 0;
                reset = rndText[i] + move;
                if(reset > 122)
                {
                    reset -= 26;
                }

                originalTextArray[i] = (char)(reset);
            }
            // Caesarova sifra - odsifrovani
            for (int i = 0; i < rndText.Length; i++)
            {
                int reset = 0;
                reset = originalTextArray[i] - move;
                if(reset < 97)
                {
                    reset += 26;
                }
                decodedOriginalTextArray[i] = (char)(reset);

            }
            Console.WriteLine(charArr);
            Console.WriteLine(decharArr);
            Console.WriteLine(originalTextArray);
            Console.WriteLine(decodedOriginalTextArray);
            Console.ReadLine();
        }
    }
}
