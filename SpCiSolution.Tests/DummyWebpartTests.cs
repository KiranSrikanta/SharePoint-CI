using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpCiSolution.Tests
{
    [TestClass]
    public class DummyWebpartTests
    {
        DummyWebPart webpart;

        [TestInitialize]
        public void Setup()
        {
            webpart = new DummyWebPart();
        }

        [TestMethod]
        public void TestMessage()
        {
            Assert.AreEqual(webpart.GetDummyMessage(), "Nothing to see here");
        }
    }
}
