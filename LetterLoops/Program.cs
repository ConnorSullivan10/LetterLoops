using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a sequence of letters to see fancy things happen");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            string letterSequence = Console.ReadLine().ToLower();
            var builder = "";
            for (int i = 0; i < letterSequence.Length; i++)
            {
                // for each letter/char, write a capital version of that letter, and lowercase versions of that letter multiplied by the index+1
                var position = i + 1; 
                for (var k = 0; k < position; k++)
                {
                    if (k == 0)
                    {
                        char upperCase = Char.ToUpper(letterSequence[i]);
                        builder += upperCase;
                    }
                    else
                    {
                        builder += letterSequence[i];
                    }
                }
                builder += "-";
            }
            char[] charsToTrim1 = { '-' };
            
            Console.WriteLine(builder.TrimEnd(charsToTrim1));
        }
    }
}
