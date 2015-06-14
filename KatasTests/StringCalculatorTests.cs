#region

using System;
using Katas;
using log4net;
using NUnit.Framework;
using Rhino.Mocks;

#endregion

namespace KatasTests
{
    [TestFixture]
    public class StringCalculatorTests
    {

        private StringCalculator stringCalculator = null;
        private ILog log = null;
        private IWebservice webservice = null;

        [SetUp]
        public void SetUp()
        {
            log = MockRepository.GenerateMock<ILog>();
            webservice = MockRepository.GenerateMock<IWebservice>();
            stringCalculator = new StringCalculator(webservice, log);

        }

        [TestCase("", 0, TestName = "AddReturnsZeroOnEmptyString")]
        [TestCase("1", 1, TestName = "AddReturnsIntValueOfSingleNumberGivenAsString")]
        [TestCase("1,3", 4, TestName = "AddReturnsSumOfTwoNumbersGivenAsStringSeparatedByComma")]
        [TestCase("1\n3,4", 8, TestName = "AddReturnsSumOfNumbersSeparatedByCommaOrNewline")]
        [TestCase("//;\n3;4", 7, TestName = "AddReturnsSumOfNumbersSeparatedByGivenDelimiter")]
        [TestCase("3,-4,-5", -6, TestName = "AddThrowsExceptionOnNegativeNumbers", ExpectedException = typeof(Exception), ExpectedMessage = "Not allowed: -4,-5")]
        [TestCase("4,1001", 4, TestName = "AddDoesNotAddNumbersGreaterThanThousand")]
        [TestCase("//[***]\n3***4", 7, TestName = "AddAllowsArbitraryLengthDelimiters")]
        [TestCase("//[**][,,]\n3**4,,5", 12, TestName = "AddAllowsMultipleArbitraryLengthDelimiters")]
        public void AddDoesWhatItShould(string numbersString, int expectedResult)
        {
            int res = stringCalculator.Add(numbersString);
            Assert.AreEqual(expectedResult, res);
        }

        [Test]
        public void AddWritesResultSumToLog()
        {
            stringCalculator.Add("3,5");
            log.AssertWasCalled(x => x.Info("8"));
        }

        [Test]
        public void AddNotifiesWebserviceOfLoggerException()
        {
            log.Stub(x => x.Info("3")).Throw(new Exception("broken :("));
            
            stringCalculator.Add("1,2");

            webservice.AssertWasCalled(x => x.Notify("broken :("));

        }
    }

}