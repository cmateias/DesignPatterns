using System;
using Composite;
using Composite.Tests;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class LeafTests
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
            int fakePrice = 100;
            var sut = new Leaf(fakeName, fakePrice);
            string expectedOutput = $"{fakeName} : {fakePrice}{Environment.NewLine}";

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
            int fakePrice = 100;
            var sut = new Leaf(null, fakePrice);
            string expectedOutput = $"{fakeName} : {fakePrice}{Environment.NewLine}";

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