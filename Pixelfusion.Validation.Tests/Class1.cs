using System.Collections.Generic;
using NUnit.Framework;
using SimpleValidation.Extensions;

namespace SimpleValidation.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void X()
        {
            string x = "dsds";
            x.Check().NotEmpty();

            int y = 90;
            y.Check().IsPositive();

            string[] someStrings = {"dsds", "sdsds"};
            someStrings.Check().NotEmpty().And.LengthBetween(1,2);

            var someList = new List<object>()
            {
                new object(),
                null,
                2
            };

            someList.Check().NotEmpty();

            var myDictionary = new Dictionary<string, List<object>>()
            {
                {"sss", new List<object>()}
            };

            myDictionary.Check().KeysCountBetween(1, 2);

            object xxx = new object();
        }
    }
}
