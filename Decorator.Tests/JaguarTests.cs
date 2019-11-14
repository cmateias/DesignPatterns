using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Decorator.Tests
{
    public class JaguarTests
    {
        [Test]
        public void When_ShowBasicDetails_IsRequested_Then_ConsoleWritesOut()
        {
            //setup
            var sut = new Jaguar();
            string expectedOutput = $"Name: Jaguar{Environment.NewLine}Model No: XType{Environment.NewLine}";
            //action

            using (var consoleOutput = new ConsoleOutput())
            {
                sut.ShowBasicDetails();

                //assert
                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }

        [Test]
        public void When_Price_IsRequested_Then_ExpectedResultIsReturned()
        {
            //setup
            var sut = new Jaguar();
            double expectedResult = 35000;
            //action
            var result = sut.Price();

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult, result);

        }
    }
}
