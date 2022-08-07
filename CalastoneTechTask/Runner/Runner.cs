using CalastoneTechTask.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CalastoneTechTask.Runner
{
    public class Runner
    {
        private readonly string fileName;
        private readonly IList<IFilter> filters;

        public Runner(string fileName, IList<IFilter> filters)
        {
            this.fileName = fileName;
            this.filters = filters;
        }

        public void Run()
        {
            var contents = File.ReadAllLines(fileName);
            foreach(var line in contents)
            {
                string result = line;
                foreach(var filter in filters)
                {
                    result = filter.Apply(result);
                }
                Console.WriteLine(result);
            }
        }
    }
}
