using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Strategy.Tests
{
    public class AscendingSortTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void When_Sort_IsRequested_Then_ConsoleWritesOut()
        {
            //setup
            List<string> fakeList = new List<string>();

            var sut = new AscendingSort();
            string expectedOutput = $"AscendingSort called{Environment.NewLine}";

            //action
            using (var consoleOutput = new ConsoleOutput())
            {
                sut.Sort(fakeList);

                //assert
                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }
    }
}