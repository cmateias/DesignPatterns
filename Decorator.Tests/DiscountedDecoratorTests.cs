using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Decorator.Tests
{
    public class DiscountedDecoratorTests
    {
        [Test]
        public void When_DiscountedPriceForVauxhall_IsRequested_Then_ConsoleWritesOut()
        {
            //setup
            var objVauxhall = new Vauxhall();
            var sut = new DiscountedDecorator(objVauxhall);
            double expectedPrice = 1500;
            string expectedOutput = $"Discounted Price: {expectedPrice}{Environment.NewLine}";
            //action

            using (var consoleOutput = new ConsoleOutput())
            {
                sut.DiscountedPrice();

                //assert
                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }

        [Test]
        public void When_DiscountedPriceForJaguar_IsRequested_Then_ConsoleWritesOut()
        {
            //setup
            var objJaguar = new Jaguar();
            var sut = new DiscountedDecorator(objJaguar);
            double expectedPrice = 3500;
            string expectedOutput = $"Discounted Price: {expectedPrice}{Environment.NewLine}";
            //action

            using (var consoleOutput = new ConsoleOutput())
            {
                sut.DiscountedPrice();

                //assert
                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }
    }
}
