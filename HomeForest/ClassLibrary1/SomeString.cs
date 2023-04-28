using System;

namespace ClassLibrary1
{
    public class SomeString
    {
        public string ConcatenatedString(string one, string two)
        {
            return one + two;
        }

        public string ConcatenatedStringWithSeparator(string one, string two)
        {
            return one + "/" + two;
        }
    }
}
