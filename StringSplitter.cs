using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCounter
{
    class StringSplitter
    {
        public static IEnumerable<string> SplitIntoWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                throw new Exception("string is empty or null");
            }

            return Regex.Replace(sentence.ToLower(), @"[^\w\s]", "").Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
          
        }
    }
}
