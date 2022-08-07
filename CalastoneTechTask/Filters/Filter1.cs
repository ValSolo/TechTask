using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalastoneTechTask.Filters
{
    public class Filter1 : IFilter
    {
        HashSet<Char> charSet = new HashSet<char>(){'a','e','i','o','u'};

        public string Apply(string input)
        {
            var words = input.Split(' ');
            var filtered = words.Where(x => !HasVowelInTheMiddle(x));
            return string.Join(' ', filtered);
        }

        bool HasVowelInTheMiddle(string word) {
            word = String.Join("", word.Where(c => Char.IsDigit(c) || Char.IsLetter(c)));   //should I strip the world of extra characters though?
            if (word.Length < 1) return true;

            var mid = word.Length / 2;
            if (word.Length % 2 == 1)
            {
                return IsWovel(word[mid]);
            }
            else
            {
                return IsWovel(word[mid-1]) || IsWovel(word[mid]);
            }
        }

        bool IsWovel(char ch)
        {
            return charSet.Contains(Char.ToLower(ch));
        }
    }
}
