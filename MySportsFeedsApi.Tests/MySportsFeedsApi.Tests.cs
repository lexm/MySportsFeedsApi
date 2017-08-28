using System;
using NUnit.Framework;
using System.Threading.Tasks;

namespace MySportsFeedsApi.Tests
{
    [TestFixture]
    public class MySportsFeedsApiTests
    {
        [TestCase("json")]
        [TestCase("xml")]
        [TestCase("csv")]
        [TestCase("xsd")]
        [TestCase("JSON")]
        [TestCase("XML")]
        [TestCase("CSV")]
        [TestCase("XSD")]
        public void VerifyFormat_True(string format)
        {
            //Act
            bool result = MySportsFeedsApi.VerifyFormat(format);

            //Assert
            Assert.IsTrue(result);
        }

        [TestCase("notJson")]
        [TestCase(".JSON")]
        [TestCase(".XSD")]
        public void VerifyFormat_False(string format)
        {
            //Act
            bool result = MySportsFeedsApi.VerifyFormat(format);

            //Assert
            Assert.IsFalse(result);
        }
    }
}