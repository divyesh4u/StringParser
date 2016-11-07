using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCounter
{
    class StringParser
    {

        public IDictionary<string, int> Parse(string sentence)
        {
            var words = StringSplitter.SplitIntoWords(sentence);
            return words.GroupBy(word => word).ToDictionary(group => group.Key, group => group.Count());

        }
    }
}
