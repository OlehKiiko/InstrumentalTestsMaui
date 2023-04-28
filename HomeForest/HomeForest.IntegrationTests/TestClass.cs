using ClassLibrary1;
using Xunit;

namespace HomeForest.IntegrationTests
{
    public class TestClass
    {
        private readonly SomeString _someString;

        public TestClass()
        {
            _someString = new SomeString();
        }

        [Fact]
        public void ConcatTwoStrings()
        {
            var one = "one";
            var two = "two";

            var res = _someString.ConcatenatedString(one, two);

            Assert.Equal("onetwo", res);
        }

        [Fact]
        public void ConcatTwoStrings_OneEmpty()
        {
            var one = "one";
            var two = string.Empty;

            var res = _someString.ConcatenatedString(one, two);

            Assert.Equal("one", res);
        }
    }
}
