using CalastoneTechTask.Filters;
using NUnit.Framework;

namespace CalastoneTechTaskTests
{
    public class FilterTests
    {
        [Test]
        public void Filter1Test()
        {
            var input = @"Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice";

            var filter = new Filter1();

            var result = filter.Apply(input);

            Assert.That(result, Is.EqualTo("beginning tired sitting by sister the and nothing once"));
        }

        [Test]
        public void Filter2Test() 
        {
            var input = @"Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice";

            var filter = new Filter2();

            var result = filter.Apply(input);

            Assert.That(result, Is.EqualTo("Alice was beginning get very tired sitting her sister the bank, and having nothing do: once twice"));
        }

        [Test]
        public void Filter3Test()
        {
            var input = @"Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice";

            var filter = new Filter3();

            var result = filter.Apply(input);

            Assert.That(result, Is.EqualTo("Alice was beginning very of by her on bank, and of having do: once or"));
        }
    }
}