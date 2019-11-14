using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Decorator.Tests
{
   public class VauxhallTests
    {
        [Test]
        public void When_ShowBasicDetails_IsRequested_Then_ConsoleWritesOut()
        {
            //setup
            var sut = new Vauxhall();
            string expectedOutput = $"Name: Vauxhall{Environment.NewLine}Model No: Astra{Environment.NewLine}";
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
            var sut = new Vauxhall();
            double expectedResult = 15000;
            //action
            var result = sut.Price();

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResult, result);

        }
    }
}
