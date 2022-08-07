using System;
using System.Collections.Generic;
using System.Text;

namespace CalastoneTechTask.Filters
{
    public interface IFilter
    {
        string Apply(string input);
    }
}
