using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //CapitalizingLetters cpt = new CapitalizingLetters();
            //cpt.GetUserInput();


            string userInput = Console.ReadLine();
            string result = "";
            char[] theTextInput = userInput.ToCharArray();
            string capitalizing = theTextInput[0].ToString();
            string firstLetterCapital = capitalizing.ToUpper();

            result += firstLetterCapital;
            for (int index = 1; index < userInput.Length; index++)
            {
                if (userInput[index] == ' ')
                {
                    if (char.IsLower(userInput[index + 1]))
                    {
                        index++;
                        result += (" " + char.ToUpper(userInput[index]));
                    }
                }
                else
                {
                    result += userInput[index];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
