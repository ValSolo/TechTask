using CalastoneTechTask.Filters;
using System;
using System.Collections.Generic;

namespace CalastoneTechTask
{
    internal class Program
    {
        private const string FileName = @"..\..\..\SampleText.txt";

        static void Main(string[] args)
        {
            var filters = new List<IFilter>{
                new Filter1(),
                new Filter2(),
                new Filter3()
            };
            var runner = new Runner.Runner(FileName, filters);
            runner.Run();
        }
    }
}
