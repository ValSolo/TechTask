using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalastoneTechTask.Filters
{
    public class Filter3 : IFilter
    {
        public string Apply(string input)
        {
            var words = input.Split(' ');
            var filtered = words.Where(x => !x.Contains('t'));
            return string.Join(' ', filtered);
        }
    }
}
