using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen12112020
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string EnterString = "";
            string firstCharacter = "";
            string LastCharacter = "";
            string midleString = "";
            string BuildString = "";
            string ResultStringBefore = "";
            string ResutlFinalString = "";
            int countDistinctCharacters = 0;

            Console.WriteLine("Captura String");
            EnterString = Console.ReadLine();
            string[] words = EnterString.Split(' ');
            foreach (var word in words)
            {
                 firstCharacter = "";
                 LastCharacter = "";
                 midleString = "";
                 BuildString = "";
                 ResultStringBefore = "";
                countDistinctCharacters = 0;

                firstCharacter = firstCharacter + word.Substring(0, 1);
                midleString = word.Substring(1, word.Length - 2);
                foreach (char character in midleString)
                {
                    if (!BuildString.Contains(character))
                    {
                        BuildString = BuildString + character;
                        countDistinctCharacters++;
                    }
                }
                LastCharacter = LastCharacter + word.Substring(word.Length - 1, 1);
                ResultStringBefore = firstCharacter + countDistinctCharacters.ToString() + LastCharacter;
                ResutlFinalString = ResutlFinalString + ResultStringBefore + " ";
            }
            Regex.Replace(@"[^\w\.@-]", ResutlFinalString, " ", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            Console.WriteLine(EnterString + " = " + ResutlFinalString);
            Console.ReadKey();
        }

       

    }
}