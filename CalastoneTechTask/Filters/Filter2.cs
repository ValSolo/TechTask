using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalastoneTechTask.Filters
{
    public class Filter2 : IFilter
    {
        public string Apply(string input)
        {
            var words = input.Split(' ');
            var filtered = words.Where(x => x.Length > 2);
            return string.Join(' ', filtered);
        }
    }
}
