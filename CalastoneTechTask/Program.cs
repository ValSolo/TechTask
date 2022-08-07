using CalastoneTechTask.Filters;
using System;
using System.Collections.Generic;
using System.IO;

namespace CalastoneTechTask
{
    internal class Program
    {
        private const string FileName = @"..\..\..\SampleText.txt";

        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, FileName);
            var filters = new List<IFilter>{
                new Filter1(),
                new Filter2(),
                new Filter3()
            };
            var runner = new Runner.Runner(path, filters);
            runner.Run();
        }
    }
}
