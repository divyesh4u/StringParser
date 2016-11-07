using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

               Console.WriteLine("Please enter sentence for word count...\n");

               string sentence = Console.ReadLine();
               var wordCounter = new StringParser().Parse(sentence);
               foreach (var word in wordCounter)
               {
                   Console.WriteLine(word.Key + " - " + word.Value);
               }

               Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
