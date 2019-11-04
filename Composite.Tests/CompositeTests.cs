using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Composite.Tests
{
    public class CompositeTests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void When_DisplayPrice_IsRequested_Then_ConsoleWritesOut()
        {
            //setup
            string fakeName = "fakeName";
            var sut = new Composite(fakeName);
            string expectedOutput = $"{fakeName}{Environment.NewLine}";

            //action
            using (var consoleOutput = new ConsoleOutput())
            {
                sut.DisplayPrice();

                //assert
                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }

        [Test]
        public void When_DisplayPrice_IsRequested_And_NoNameIsPassedThrough_ThenConsoleWritesOutDifferent()
        {
            //setup
            string fakeName = "fakeName";
            var sut = new Composite(null);
            string expectedOutput = $"{fakeName}{Environment.NewLine}";

            //action
            using (var consoleOutput = new ConsoleOutput())
            {
                sut.DisplayPrice();

                //assert
                Assert.AreNotEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }
    }
}
